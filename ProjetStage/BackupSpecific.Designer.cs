
namespace ProjetStage
{
    partial class BackupSpecific
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupSpecific));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRetour = new System.Windows.Forms.PictureBox();
            this.listFileViewSpec = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataListTable = new System.Windows.Forms.DataGridView();
            this.labelTableList = new System.Windows.Forms.Label();
            this.btnSpecific = new Guna.UI2.WinForms.Guna2GradientButton();
            this.infoProperty = new System.Windows.Forms.ListView();
            this.Propriété = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requete = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRequete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gridViewData = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetour)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.Image = global::ProjetStage.Properties.Resources.curve_arrow;
            this.btnRetour.Location = new System.Drawing.Point(12, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(37, 25);
            this.btnRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRetour.TabIndex = 14;
            this.btnRetour.TabStop = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listFileViewSpec
            // 
            this.listFileViewSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.listFileViewSpec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFileViewSpec.ForeColor = System.Drawing.Color.White;
            this.listFileViewSpec.HideSelection = false;
            this.listFileViewSpec.Location = new System.Drawing.Point(29, 67);
            this.listFileViewSpec.Name = "listFileViewSpec";
            this.listFileViewSpec.Size = new System.Drawing.Size(170, 342);
            this.listFileViewSpec.TabIndex = 15;
            this.listFileViewSpec.TileSize = new System.Drawing.Size(228, 20);
            this.listFileViewSpec.UseCompatibleStateImageBehavior = false;
            this.listFileViewSpec.View = System.Windows.Forms.View.Tile;
            this.listFileViewSpec.DoubleClick += new System.EventHandler(this.listFileViewSpec_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Listes des Bases";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(34, 51);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(431, 280);
            this.txtInfo.TabIndex = 14;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Controls.Add(this.txtInfo);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(311, 67);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(496, 342);
            this.guna2Panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(140, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Backup Spécifique\r\n";
            // 
            // dataListTable
            // 
            this.dataListTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dataListTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataListTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataListTable.GridColor = System.Drawing.Color.White;
            this.dataListTable.Location = new System.Drawing.Point(209, 67);
            this.dataListTable.Name = "dataListTable";
            this.dataListTable.RowHeadersVisible = false;
            this.dataListTable.RowHeadersWidth = 10;
            this.dataListTable.Size = new System.Drawing.Size(170, 342);
            this.dataListTable.TabIndex = 22;
            // 
            // labelTableList
            // 
            this.labelTableList.AutoSize = true;
            this.labelTableList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTableList.Location = new System.Drawing.Point(228, 46);
            this.labelTableList.Name = "labelTableList";
            this.labelTableList.Size = new System.Drawing.Size(124, 20);
            this.labelTableList.TabIndex = 20;
            this.labelTableList.Text = "Listes des Tables";
            // 
            // btnSpecific
            // 
            this.btnSpecific.Animated = true;
            this.btnSpecific.BackColor = System.Drawing.Color.Transparent;
            this.btnSpecific.BorderRadius = 9;
            this.btnSpecific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpecific.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecific.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecific.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecific.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecific.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpecific.FillColor = System.Drawing.Color.FloralWhite;
            this.btnSpecific.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnSpecific.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecific.ForeColor = System.Drawing.Color.Black;
            this.btnSpecific.Location = new System.Drawing.Point(627, 428);
            this.btnSpecific.Name = "btnSpecific";
            this.btnSpecific.Size = new System.Drawing.Size(161, 39);
            this.btnSpecific.TabIndex = 22;
            this.btnSpecific.Text = "Backup de la base";
            this.btnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // infoProperty
            // 
            this.infoProperty.BackColor = System.Drawing.Color.White;
            this.infoProperty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Propriété,
            this.Valeur});
            this.infoProperty.ForeColor = System.Drawing.Color.Black;
            this.infoProperty.GridLines = true;
            this.infoProperty.HideSelection = false;
            this.infoProperty.Location = new System.Drawing.Point(29, 428);
            this.infoProperty.Name = "infoProperty";
            this.infoProperty.Size = new System.Drawing.Size(350, 121);
            this.infoProperty.TabIndex = 23;
            this.infoProperty.UseCompatibleStateImageBehavior = false;
            this.infoProperty.View = System.Windows.Forms.View.Details;
            // 
            // Propriété
            // 
            this.Propriété.Text = "Propriété";
            this.Propriété.Width = 90;
            // 
            // Valeur
            // 
            this.Valeur.Text = "Valeur";
            this.Valeur.Width = 255;
            // 
            // requete
            // 
            this.requete.Animated = true;
            this.requete.BorderColor = System.Drawing.Color.White;
            this.requete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.requete.DefaultText = "";
            this.requete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.requete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.requete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.requete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.requete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.requete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.requete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.requete.ForeColor = System.Drawing.Color.White;
            this.requete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.requete.Location = new System.Drawing.Point(854, 505);
            this.requete.Multiline = true;
            this.requete.Name = "requete";
            this.requete.PasswordChar = '\0';
            this.requete.PlaceholderText = "Requête SQL";
            this.requete.SelectedText = "";
            this.requete.Size = new System.Drawing.Size(395, 55);
            this.requete.TabIndex = 24;
            // 
            // btnRequete
            // 
            this.btnRequete.Animated = true;
            this.btnRequete.BackColor = System.Drawing.Color.Transparent;
            this.btnRequete.BorderRadius = 9;
            this.btnRequete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequete.FillColor = System.Drawing.Color.FloralWhite;
            this.btnRequete.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnRequete.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequete.ForeColor = System.Drawing.Color.Black;
            this.btnRequete.Location = new System.Drawing.Point(615, 473);
            this.btnRequete.Name = "btnRequete";
            this.btnRequete.Size = new System.Drawing.Size(173, 31);
            this.btnRequete.TabIndex = 25;
            this.btnRequete.Text = "Envoyer la requête";
            this.btnRequete.Click += new System.EventHandler(this.btnRequete_Click);
            // 
            // gridViewData
            // 
            this.gridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewData.Location = new System.Drawing.Point(401, 570);
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.RowHeadersVisible = false;
            this.gridViewData.Size = new System.Drawing.Size(240, 150);
            this.gridViewData.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetStage.Properties.Resources.grinning;
            this.pictureBox1.Location = new System.Drawing.Point(206, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BackupSpecific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(859, 570);
            this.Controls.Add(this.gridViewData);
            this.Controls.Add(this.btnRequete);
            this.Controls.Add(this.requete);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.infoProperty);
            this.Controls.Add(this.btnSpecific);
            this.Controls.Add(this.dataListTable);
            this.Controls.Add(this.labelTableList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFileViewSpec);
            this.Controls.Add(this.btnRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupSpecific";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupSpecific";
            this.Load += new System.EventHandler(this.BackupSpecific_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRetour)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnRetour;
        private System.Windows.Forms.ListView listFileViewSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtInfo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTableList;
        private Guna.UI2.WinForms.Guna2GradientButton btnSpecific;
        private System.Windows.Forms.ListView infoProperty;
        private System.Windows.Forms.ColumnHeader Propriété;
        private System.Windows.Forms.ColumnHeader Valeur;
        private System.Windows.Forms.DataGridView dataListTable;
        private Guna.UI2.WinForms.Guna2TextBox requete;
        private Guna.UI2.WinForms.Guna2GradientButton btnRequete;
        private System.Windows.Forms.DataGridView gridViewData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}