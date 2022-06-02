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
using System.IO;
using System.Security.Cryptography;

namespace ProjetStage
{
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region Decrytage
        static string Decrypter(string text)
        {
            try
            {
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeyByte = { };
                publickeyByte = Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[text.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(text.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeyByte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string mdp_crypte = "P3IxixqAhg0=";
            string pass = Decrypter(mdp_crypte);
            string userName = txtUserName.Text;
            string password = txtPass.Text;

            if (userName == name && password == pass)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (userName == "")
            {
                MessageBox.Show("Veuillez entrer votre identifiant!!!");
            }
            else if (password == "")
            {
                MessageBox.Show("Veuillez entrer votre mot de passe!!!");
            }
            else
            {
                MessageBox.Show("Utilisateur non connu!!!! Vous ne pouvez que consulter la liste des bases de données","Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPass.Clear();
                txtUserName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        FileList winList = new FileList();
        private void label4_Click(object sender, EventArgs e)
        {
            winList.ShowDialog();
        }
    
    }
}
