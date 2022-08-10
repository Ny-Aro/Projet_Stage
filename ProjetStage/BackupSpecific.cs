using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace ProjetStage
{
    public partial class BackupSpecific : Form
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
        public BackupSpecific()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BackupSpecific_Load(object sender, EventArgs e)
        {

            #region hide element non utile
            labelTableList.Hide();
            btnSpecific.Hide();
            infoProperty.Hide();
            dataListTable.Hide();
            requete.Hide();
            btnRequete.Hide();
            gridViewData.Hide();
            #endregion

            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            var listItems = listFileViewSpec.Items;

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
                            string nameFile = fi.Name.Split('.').First();
                            listItems.Add(nameFile);
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

        private void listFileViewSpec_DoubleClick(object sender, EventArgs e)
        {

            #region Fermeture element
            txtInfo.Hide();
            guna2Panel1.Hide();
            label2.Hide();
            pictureBox1.Hide();
            gridViewData.Hide();
            #endregion

            infoProperty.Items.Clear();
            dataListTable.DataSource = null;

            var selectedItems = listFileViewSpec.SelectedItems;
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;

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

                    //Affichage des fichiers 
                    foreach (FileInfo file in files)
                    {
                        string nameBase = file.Name.Split('.').First();
                        if (nameBase == selectedItems[0].Text)
                        {
                            
                            #region Propriete Fichier .FB

                            infoProperty.Show();

                            //Ajout element
                            string[] element = new string[3];
                            ListViewItem itm;

                            element[0] = "Fichier";
                            element[1] = selectedItems[0].Text +".FB";
                            itm = new ListViewItem(element);
                            infoProperty.Items.Add(itm);

                            element[0] = "Chemin DB";
                            element[1] = file.FullName;
                            itm = new ListViewItem(element);
                            infoProperty.Items.Add(itm);

                            element[0] = "Taille DB";
                            element[1] = (file.Length / 1024) + " ko";
                            itm = new ListViewItem(element);
                            infoProperty.Items.Add(itm);

                            element[0] = "Création DB";
                            element[1] = file.CreationTime.ToString();
                            itm = new ListViewItem(element);
                            infoProperty.Items.Add(itm);

                            #endregion

                            #region Connexion à la base

                            string connectionString = $"Database={file.FullName};User=SYSDBA;Password=masterkey;Server=localhost";
                            FbConnection conn = new FbConnection();
                            try
                            {
                                if (conn.State != ConnectionState.Open)
                                {
                                    conn.ConnectionString = connectionString;
                                    conn.Open();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            #endregion

                            #region Récuperation de la liste des tables
                            DataTable dt = new DataTable();
                            string sql = "select rdb$relation_name from rdb$relations where rdb$view_blr is null and (rdb$system_flag is null or rdb$system_flag = 0);";
                            FbDataAdapter adapter = new FbDataAdapter(sql,connectionString);
                            adapter.Fill(dt);
                            #endregion

                            #region Creation listview pour les informations du fichier
                            labelTableList.Show();
                            dataListTable.Show();

                            dataListTable.DataSource = dt;
                            
                            btnSpecific.Show();
                            btnSpecific.Location = new Point(678, 428);
                            #endregion

                            #region Edit element et affichage nouvel element
                            guna2Panel1.Show();
                            guna2Panel1.Size = new Size(440, 342);
                            guna2Panel1.Location = new Point(400, 67);
                            btnRequete.Show();
                            btnRequete.Location = new Point(648 ,137);
                            requete.Show();
                            requete.Location = new Point(422, 77);
                            #endregion

                            #region Fermeture de la base
                            conn.Close();
                            #endregion

                        }
                    }
                    
                }
            }
            #endregion

        }

        private void btnRequete_Click(object sender, EventArgs e)
        {
            
            string query = requete.Text;
            DataTable dt = new DataTable();
            var selectedItems = listFileViewSpec.SelectedItems;
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;

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

                    //Affichage des fichiers 
                    foreach (FileInfo file in files)
                    {
                        string nameBase = file.Name.Split('.').First();

                        if (nameBase == selectedItems[0].Text)
                        {

                            #region Connexion à la base

                            string connectionString = $"Database={file.FullName};User=SYSDBA;Password=masterkey;Server=localhost";
                            FbConnection conn = new FbConnection();
                            try
                            {
                                if (conn.State != ConnectionState.Open)
                                {
                                    conn.ConnectionString = connectionString;
                                    conn.Open();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            #endregion

                            #region Execution de la commande SQL Firebird
                            try
                            {
                                if (query == "")
                                {
                                    MessageBox.Show("Le champ est vide");
                                }
                                else if (query.Contains("select"))
                                {
                                    FbDataAdapter adapter = new FbDataAdapter(query, connectionString);
                                    adapter.Fill(dt);
                                }
                                else if (query.Contains("insert"))
                                {
                                    FbCommand insertCommand = new FbCommand(query);
                                    insertCommand.CommandType = CommandType.Text;
                                    insertCommand.Connection = conn;
                                    insertCommand.ExecuteNonQuery();
                                }
                                else if (query.Contains("update"))
                                {
                                    FbCommand updateCommand = new FbCommand(query);
                                    updateCommand.Connection = conn;
                                    updateCommand.CommandType = CommandType.Text;
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Commande non valide");
                            }
                            
                            #endregion

                            #region Affichage du gridview pour les données
                            gridViewData.Show();
                            gridViewData.Size = new Size(395, 230);
                            gridViewData.Location = new Point(422, 173);
                            gridViewData.BackgroundColor = Color.FromArgb(42, 40, 60);
                            gridViewData.DataSource = dt;
                            #endregion

                            #region Fermeture de la base
                            conn.Close();
                            #endregion

                        }
                    }

                }
            }
            #endregion

            requete.Clear();
        }

        private void btnSpecific_Click(object sender, EventArgs e)
        {

            DBAccess dBAccess = new DBAccess();
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            var selectedItems = listFileViewSpec.SelectedItems;

            #region Backup de la base

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

                    foreach (DirectoryInfo backDir in backDirs)
                    {
                        foreach (FileInfo file in files)
                        {
                            string nameBase = file.Name.Split('.').First();
                            if (nameBase == selectedItems[0].Text)
                            {
                                string dir_name = file.Directory.Name;
                                if (dir_name != item.Recherche)
                                {
                                    string t = parentPath + @"\" + backDir + "\\" + dir_name;
                                    if (!Directory.Exists(t))
                                    {
                                        Directory.CreateDirectory(t);
                                    }
                                    //Execution sauvegarde.bat si il y avait un sous dossier dans le dossier de recherche
                                    Process.Start("sauvegarde.bat", file.FullName + " " + t + @"\" + nameBase);
                                }
                                else
                                {
                                    //Execution sauvegarde.bat sans sous dossier
                                    Process.Start("sauvegarde.bat", file.FullName + " " + parentPath + @"\" + backDir.Name + @"\" + nameBase);
                                }
                            }
                        }
                    }

                }
            }
            #endregion

            #region Historique
            //Parametre de l'insertion
            string time = DateTime.Now.ToString();
            string description = "Backup de "+selectedItems[0].Text;

            SqlCommand insert_gbak = new SqlCommand("insert into tblHistory(Description,time) values(@description,@time)");
            insert_gbak.Parameters.AddWithValue("@time", time);
            insert_gbak.Parameters.AddWithValue("@description", description);

            int row = dBAccess.executeQuery(insert_gbak);
            #endregion

            //Notification Box Message
            Message msg = new Message();
            msg.ShowDialog();

        }

    }
}
