using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace ProjetStage
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public Dashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            var listItems = listFileView.Items;

            #region Recherche des fichiers .FB et affichage
            foreach (CheminElement item in chemin.Chemins)
            {

                //Dossier source
                DirectoryInfo dirSource = new DirectoryInfo(item.Source);
                //Dossier de recherche
                DirectoryInfo[] rechdDirs = dirSource.GetDirectories(item.Recherche, SearchOption.AllDirectories);

                foreach (DirectoryInfo childDir in rechdDirs)
                {
                    //Recherche des fichiers
                    IEnumerable<FileInfo> l = childDir.GetFiles("*.*", SearchOption.AllDirectories);
                    IEnumerable<FileInfo> files =
                            from file in l
                            where file.Extension == ".FB"
                            orderby file.Name
                            select file;

                    //Affichage des fichiers et ajout dans la listView
                    if (files.Count() != 0)
                    {
                        foreach (FileInfo fi in files)
                        {
                            listItems.Add(fi.FullName);
                        }

                    }
                    else
                    {
                        listItems.Add("Les fichiers recherchés n'existent pas");
                    }
                }
            }
            #endregion

        }

        private void btnNbackup_Click(object sender, EventArgs e)
        {

            DBAccess dBAccess = new DBAccess();
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            string name = chemin.NameChemins;

            #region Recherche des fichiers .FB ,Creation et Ecriture du fichier Batch et Exécution

            foreach (CheminElement item in chemin.Chemins)
            {

                //Dossier source, recherche, backup
                DirectoryInfo dirSource = new DirectoryInfo(item.Source);
                DirectoryInfo[] rechdDirs = dirSource.GetDirectories(item.Recherche, SearchOption.AllDirectories);
                DirectoryInfo[] backDirs = dirSource.GetDirectories(item.Backup, SearchOption.AllDirectories);

                foreach (DirectoryInfo childDir in rechdDirs)
                {
                    //Recherche des fichiers
                    IEnumerable<FileInfo> l = childDir.GetFiles("*.*", SearchOption.AllDirectories);
                    IEnumerable<FileInfo> files =
                        from file in l
                        where file.Extension == ".FB"
                        orderby file.Name
                        select file;

                    string newdir = childDir.FullName;
                    string parentPath = childDir.Parent.FullName;
                    string batPath = Path.Combine(newdir, "nbackup.bat");

                    foreach (DirectoryInfo backDir in backDirs)
                    {
                        //Creation du fichier .Bat  dans le dossier de recherche 
                        using (FileStream f = File.Create(batPath))
                        {
                            using (StreamWriter command = new StreamWriter(f))
                            {

                                foreach (FileInfo el in files)
                                {

                                    string nameBack = el.Name.Split('.').First();
                                    string dir_name = el.Directory.Name;
                                    if (dir_name != item.Recherche)
                                    {
                                        string t = parentPath + @"\" + backDir + "\\" + dir_name;
                                        if (!Directory.Exists(t))
                                        {
                                            Directory.CreateDirectory(t);
                                        }
                                        //Ecriture dans le fichier nbackup.bat
                                        command.WriteLine(@"""C:\Program Files\Firebird\Firebird_2_5\bin\nbackup.exe"" -b -v " + el.FullName + " " + t + @"\" + nameBack + ".nbk -user SYSDBA -pass masterkey");
                                    }
                                    else
                                    {
                                        //Ecriture dans le fichier nbackup.bat
                                        command.WriteLine(@"""C:\Program Files\Firebird\Firebird_2_5\bin\nbackup.exe"" -b -v " + el.FullName + " " + parentPath + @"\" + backDir.Name + @"\" + nameBack + ".nbk -user SYSDBA -pass masterkey");
                                    }

                                }

                            }
                        }
                        //Execution du fichier .bat
                        try
                        {
                            Process.Start(batPath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

            }

            #endregion

            #region Historique
            //Parametre de l'insertion
            string time = DateTime.Now.ToString();
            string description = "NBACKUP de tous les fichiers";

            SqlCommand insert_nbackup = new SqlCommand("insert into tblHistory(Description,time) values(@description,@time)");
            insert_nbackup.Parameters.AddWithValue("@time", time);
            insert_nbackup.Parameters.AddWithValue("@description", description);

            int row = dBAccess.executeQuery(insert_nbackup);
            #endregion

            //Notification Box Message
            Message msg = new Message();
            msg.ShowDialog();
            
        }

        private void btnGbak_Click(object sender, EventArgs e)
        {

            DBAccess dBAccess = new DBAccess();
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            string name = chemin.NameChemins;

            #region Recherche des fichiers .FB ,Creation et Ecriture du fichier Batch et Exécution

            foreach (CheminElement item in chemin.Chemins)
            {

                //Dossier source, recherche, backup
                DirectoryInfo dirSource = new DirectoryInfo(item.Source);
                DirectoryInfo[] rechdDirs = dirSource.GetDirectories(item.Recherche, SearchOption.AllDirectories);
                DirectoryInfo[] backDirs = dirSource.GetDirectories(item.Backup, SearchOption.AllDirectories);

                foreach (DirectoryInfo childDir in rechdDirs)
                {
                    //Recherche des fichiers
                    IEnumerable<FileInfo> l = childDir.GetFiles("*.*", SearchOption.AllDirectories);
                    IEnumerable<FileInfo> files =
                        from file in l
                        where file.Extension == ".FB"
                        orderby file.Name
                        select file;

                    string newdir = childDir.FullName;
                    string parentPath = childDir.Parent.FullName;
                    string batPath = Path.Combine(newdir, "gbak.bat");

                    foreach (DirectoryInfo backDir in backDirs)
                    {
                        //Creation du fichier .bat  dans le dossier de recherche 
                        using (FileStream f = File.Create(batPath))
                        {
                            using (StreamWriter command = new StreamWriter(f))
                            {
                                foreach (FileInfo el in files)
                                {
                                    string nameBack = el.Name.Split('.').First();
                                    string dir_name = el.Directory.Name;
                                    if (dir_name != item.Recherche)
                                    {
                                        string t = parentPath + @"\" + backDir + "\\" + dir_name;
                                        if (!Directory.Exists(t))
                                        {
                                            Directory.CreateDirectory(t);
                                        }
                                        //Ecriture dans gbak.bak
                                        command.WriteLine(@"""C:\Program Files\Firebird\Firebird_2_5\bin\gbak.exe"" -b -v " + el.FullName + " " + t + @"\" + nameBack + ".fbk -user SYSDBA -pass masterkey");
                                    }
                                    else
                                    {
                                        //Ecriture dans gbak.bak
                                        command.WriteLine(@"""C:\Program Files\Firebird\Firebird_2_5\bin\gbak.exe"" -b -v " + el.FullName + " " + parentPath + @"\" + backDir.Name + @"\" + nameBack + ".fbk -user SYSDBA -pass masterkey");
                                    }

                                }

                            }
                        }
                        //Execution sauvegarde.bat
                        try
                        {
                            Process.Start(batPath);
                        }
                        catch (Exception ex)
                        {
                           MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            #endregion

            #region Historique
            //Parametre de l'insertion
            string time = DateTime.Now.ToString();
            string description = "GBAK de tous les fichiers";

            SqlCommand insert_gbak = new SqlCommand("insert into tblHistory(Description,time) values(@description,@time)");
            insert_gbak.Parameters.AddWithValue("@time", time);
            insert_gbak.Parameters.AddWithValue("@description", description);

            int row = dBAccess.executeQuery(insert_gbak);
            #endregion

            //Notification Box Message
            Message msg = new Message();
            msg.ShowDialog();

        }
        
        Information info = new Information();
        private void infoIcon_Click(object sender, EventArgs e)
        {
            info.ShowDialog();
        }


        Historique history = new Historique();
        private void historyIcon_Click(object sender, EventArgs e)
        {
            history.ShowDialog();   
        }

        private void retourIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    
    }
}
