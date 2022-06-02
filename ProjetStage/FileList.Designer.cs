
namespace ProjetStage
{
    partial class FileList
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
            this.listFileView = new System.Windows.Forms.ListView();
            this.rechercheFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.rechercheBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rechercheBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listFileView
            // 
            this.listFileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.listFileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFileView.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFileView.ForeColor = System.Drawing.Color.White;
            this.listFileView.HideSelection = false;
            this.listFileView.Location = new System.Drawing.Point(39, 35);
            this.listFileView.Name = "listFileView";
            this.listFileView.Size = new System.Drawing.Size(365, 186);
            this.listFileView.TabIndex = 1;
            this.listFileView.UseCompatibleStateImageBehavior = false;
            this.listFileView.View = System.Windows.Forms.View.List;
            // 
            // rechercheFile
            // 
            this.rechercheFile.Animated = true;
            this.rechercheFile.BorderColor = System.Drawing.Color.Transparent;
            this.rechercheFile.BorderRadius = 5;
            this.rechercheFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rechercheFile.DefaultText = "";
            this.rechercheFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rechercheFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rechercheFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rechercheFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rechercheFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.rechercheFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rechercheFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rechercheFile.ForeColor = System.Drawing.Color.White;
            this.rechercheFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rechercheFile.Location = new System.Drawing.Point(168, 8);
            this.rechercheFile.Name = "rechercheFile";
            this.rechercheFile.PasswordChar = '\0';
            this.rechercheFile.PlaceholderText = "Rechercher";
            this.rechercheFile.SelectedText = "";
            this.rechercheFile.Size = new System.Drawing.Size(200, 21);
            this.rechercheFile.TabIndex = 2;
            // 
            // rechercheBtn
            // 
            this.rechercheBtn.BackColor = System.Drawing.Color.Transparent;
            this.rechercheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rechercheBtn.FillColor = System.Drawing.Color.Transparent;
            this.rechercheBtn.Image = global::ProjetStage.Properties.Resources.search;
            this.rechercheBtn.ImageRotate = 0F;
            this.rechercheBtn.Location = new System.Drawing.Point(374, 8);
            this.rechercheBtn.Name = "rechercheBtn";
            this.rechercheBtn.Size = new System.Drawing.Size(26, 21);
            this.rechercheBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rechercheBtn.TabIndex = 3;
            this.rechercheBtn.TabStop = false;
            this.rechercheBtn.Click += new System.EventHandler(this.rechercheBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetStage.Properties.Resources.curve_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(440, 250);
            this.Controls.Add(this.rechercheBtn);
            this.Controls.Add(this.rechercheFile);
            this.Controls.Add(this.listFileView);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileList";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileList";
            this.Load += new System.EventHandler(this.FileList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rechercheBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listFileView;
        private Guna.UI2.WinForms.Guna2TextBox rechercheFile;
        private Guna.UI2.WinForms.Guna2PictureBox rechercheBtn;
    }
}