using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class FileList : Form
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
        public FileList()
        {
            InitializeComponent(); 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void FileList_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rechercheBtn_Click(object sender, EventArgs e)
        {

            var nomFile = rechercheFile.Text;
            CheminSection chemin = ConfigurationManager.GetSection("chemins") as CheminSection;
            var listItems = listFileView.Items;

            //Rendre la listview vide
            listItems.Clear();

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
                            //Nom du fichier
                            string fiName = fi.Name.Split('.').First().ToLower();
                            if (nomFile == "")
                            {
                                listItems.Add(fi.FullName);
                            }
                            else if (fiName.Contains(nomFile))
                            {
                                listItems.Add(fi.FullName);
                            }
                        }
                    }
                }
            }
            #endregion

        }
    
    }
}
