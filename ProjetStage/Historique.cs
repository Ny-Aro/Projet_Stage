using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class Historique : Form
    {

        DBAccess access = new DBAccess();
        DataTable dtHistory = new DataTable();

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
        public Historique()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));         
        }

        private void Historique_Load(object sender, EventArgs e)
        {

            string query = "Select * from tblHistory";

            access.dataGridView(query, dtHistory);
            dataGridView1.DataSource = dtHistory; 

            access.closeConn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
