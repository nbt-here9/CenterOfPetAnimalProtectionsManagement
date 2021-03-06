﻿
namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.picPetsManagement = new System.Windows.Forms.PictureBox();
            this.picAdoptersManagement = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picNotification = new System.Windows.Forms.PictureBox();
            this.frmNormalControlPanel2 = new CenterOfPetAnimalProtectionsManagement.GUI.frmNormalControlPanel();
            this.frmNormalControlPanel1 = new CenterOfPetAnimalProtectionsManagement.GUI.frmNormalControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetsManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdoptersManagement)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 757);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lbWelcome.Location = new System.Drawing.Point(664, 51);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(92, 20);
            this.lbWelcome.TabIndex = 6;
            this.lbWelcome.Text = "Welcome, ";
            // 
            // picPetsManagement
            // 
            this.picPetsManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPetsManagement.BackgroundImage")));
            this.picPetsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPetsManagement.Location = new System.Drawing.Point(14, 3);
            this.picPetsManagement.Name = "picPetsManagement";
            this.picPetsManagement.Size = new System.Drawing.Size(120, 120);
            this.picPetsManagement.TabIndex = 7;
            this.picPetsManagement.TabStop = false;
            this.picPetsManagement.Click += new System.EventHandler(this.btnPetsManagement_Click);
            // 
            // picAdoptersManagement
            // 
            this.picAdoptersManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAdoptersManagement.BackgroundImage")));
            this.picAdoptersManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdoptersManagement.Location = new System.Drawing.Point(15, 3);
            this.picAdoptersManagement.Name = "picAdoptersManagement";
            this.picAdoptersManagement.Size = new System.Drawing.Size(120, 120);
            this.picAdoptersManagement.TabIndex = 8;
            this.picAdoptersManagement.TabStop = false;
            this.picAdoptersManagement.Click += new System.EventHandler(this.picAdoptersManagement_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picPetsManagement);
            this.panel1.Location = new System.Drawing.Point(742, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 199);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pets \r\nManagement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.picAdoptersManagement);
            this.panel2.Location = new System.Drawing.Point(972, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 199);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 56);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adopters\r\nManagement";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.picNotification);
            this.panel3.Location = new System.Drawing.Point(860, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 166);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Notification";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picNotification
            // 
            this.picNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNotification.BackgroundImage")));
            this.picNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNotification.Location = new System.Drawing.Point(15, 3);
            this.picNotification.Name = "picNotification";
            this.picNotification.Size = new System.Drawing.Size(120, 120);
            this.picNotification.TabIndex = 0;
            this.picNotification.TabStop = false;
            this.picNotification.Click += new System.EventHandler(this.picNotification_Click);
            // 
            // frmNormalControlPanel2
            // 
            this.frmNormalControlPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.frmNormalControlPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.frmNormalControlPanel2.Location = new System.Drawing.Point(-2, -2);
            this.frmNormalControlPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.frmNormalControlPanel2.Name = "frmNormalControlPanel2";
            this.frmNormalControlPanel2.Size = new System.Drawing.Size(1206, 49);
            this.frmNormalControlPanel2.TabIndex = 12;
            // 
            // frmNormalControlPanel1
            // 
            this.frmNormalControlPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.frmNormalControlPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.frmNormalControlPanel1.Location = new System.Drawing.Point(-1, -2);
            this.frmNormalControlPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.frmNormalControlPanel1.Name = "frmNormalControlPanel1";
            this.frmNormalControlPanel1.Size = new System.Drawing.Size(1203, 50);
            this.frmNormalControlPanel1.TabIndex = 5;
            // 
            // AdminHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.frmNormalControlPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetsManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdoptersManagement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private frmNormalControlPanel frmNormalControlPanel1;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox picPetsManagement;
        private System.Windows.Forms.PictureBox picAdoptersManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picNotification;
        private frmNormalControlPanel frmNormalControlPanel2;
    }
}