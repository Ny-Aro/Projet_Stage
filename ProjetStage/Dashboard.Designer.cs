
namespace ProjetStage
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNbackup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGbak = new Guna.UI2.WinForms.Guna2GradientButton();
            this.infoIcon = new System.Windows.Forms.PictureBox();
            this.historyIcon = new System.Windows.Forms.PictureBox();
            this.retourIcon = new System.Windows.Forms.PictureBox();
            this.listFileView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.infoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retourIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(264, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copyright by Hitechsoftware";
            // 
            // btnNbackup
            // 
            this.btnNbackup.Animated = true;
            this.btnNbackup.BackColor = System.Drawing.Color.Transparent;
            this.btnNbackup.BorderRadius = 9;
            this.btnNbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNbackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNbackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNbackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNbackup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNbackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNbackup.FillColor = System.Drawing.Color.FloralWhite;
            this.btnNbackup.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnNbackup.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbackup.ForeColor = System.Drawing.Color.Black;
            this.btnNbackup.Location = new System.Drawing.Point(138, 314);
            this.btnNbackup.Name = "btnNbackup";
            this.btnNbackup.Size = new System.Drawing.Size(146, 45);
            this.btnNbackup.TabIndex = 8;
            this.btnNbackup.Text = "NBACKUP";
            this.btnNbackup.Click += new System.EventHandler(this.btnNbackup_Click);
            // 
            // btnGbak
            // 
            this.btnGbak.Animated = true;
            this.btnGbak.BackColor = System.Drawing.Color.Transparent;
            this.btnGbak.BorderRadius = 9;
            this.btnGbak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGbak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGbak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGbak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGbak.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGbak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGbak.FillColor = System.Drawing.Color.FloralWhite;
            this.btnGbak.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnGbak.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGbak.ForeColor = System.Drawing.Color.Black;
            this.btnGbak.Location = new System.Drawing.Point(409, 314);
            this.btnGbak.Name = "btnGbak";
            this.btnGbak.Size = new System.Drawing.Size(146, 45);
            this.btnGbak.TabIndex = 9;
            this.btnGbak.Text = "GBAK";
            this.btnGbak.Click += new System.EventHandler(this.btnGbak_Click);
            // 
            // infoIcon
            // 
            this.infoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoIcon.Image = global::ProjetStage.Properties.Resources.info;
            this.infoIcon.Location = new System.Drawing.Point(659, 371);
            this.infoIcon.Name = "infoIcon";
            this.infoIcon.Size = new System.Drawing.Size(29, 33);
            this.infoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoIcon.TabIndex = 12;
            this.infoIcon.TabStop = false;
            this.infoIcon.Click += new System.EventHandler(this.infoIcon_Click);
            // 
            // historyIcon
            // 
            this.historyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyIcon.Image = global::ProjetStage.Properties.Resources.recent;
            this.historyIcon.Location = new System.Drawing.Point(12, 371);
            this.historyIcon.Name = "historyIcon";
            this.historyIcon.Size = new System.Drawing.Size(37, 33);
            this.historyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyIcon.TabIndex = 11;
            this.historyIcon.TabStop = false;
            this.historyIcon.Click += new System.EventHandler(this.historyIcon_Click);
            // 
            // retourIcon
            // 
            this.retourIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retourIcon.Image = global::ProjetStage.Properties.Resources.curve_arrow;
            this.retourIcon.Location = new System.Drawing.Point(12, 16);
            this.retourIcon.Name = "retourIcon";
            this.retourIcon.Size = new System.Drawing.Size(37, 21);
            this.retourIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.retourIcon.TabIndex = 13;
            this.retourIcon.TabStop = false;
            this.retourIcon.Click += new System.EventHandler(this.retourIcon_Click);
            // 
            // listFileView
            // 
            this.listFileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.listFileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFileView.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFileView.ForeColor = System.Drawing.Color.White;
            this.listFileView.HideSelection = false;
            this.listFileView.Location = new System.Drawing.Point(94, 61);
            this.listFileView.Name = "listFileView";
            this.listFileView.Size = new System.Drawing.Size(517, 242);
            this.listFileView.TabIndex = 14;
            this.listFileView.UseCompatibleStateImageBehavior = false;
            this.listFileView.View = System.Windows.Forms.View.List;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.listFileView);
            this.Controls.Add(this.retourIcon);
            this.Controls.Add(this.infoIcon);
            this.Controls.Add(this.historyIcon);
            this.Controls.Add(this.btnGbak);
            this.Controls.Add(this.btnNbackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retourIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnNbackup;
        private Guna.UI2.WinForms.Guna2GradientButton btnGbak;
        private System.Windows.Forms.PictureBox historyIcon;
        private System.Windows.Forms.PictureBox infoIcon;
        private System.Windows.Forms.PictureBox retourIcon;
        private System.Windows.Forms.ListView listFileView;
    }
}