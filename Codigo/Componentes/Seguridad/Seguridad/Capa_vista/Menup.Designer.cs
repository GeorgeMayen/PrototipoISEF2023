﻿
namespace Vista_Seguridad
{
    partial class Menup
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCxP = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 87);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCxP
            // 
            this.btnCxP.BackColor = System.Drawing.Color.SlateGray;
            this.btnCxP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCxP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCxP.FlatAppearance.BorderSize = 0;
            this.btnCxP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnCxP.Location = new System.Drawing.Point(0, 87);
            this.btnCxP.Name = "btnCxP";
            this.btnCxP.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnCxP.Size = new System.Drawing.Size(250, 39);
            this.btnCxP.TabIndex = 8;
            this.btnCxP.Text = "Abrir";
            this.btnCxP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCxP.UseVisualStyleBackColor = false;
            this.btnCxP.Click += new System.EventHandler(this.btnnominas_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnseguridad);
            this.panelSideMenu.Controls.Add(this.btnCxP);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 474);
            this.panelSideMenu.TabIndex = 46;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 165);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 39);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "CERRAR SESIÓN";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnseguridad
            // 
            this.btnseguridad.BackColor = System.Drawing.Color.SlateGray;
            this.btnseguridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnseguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnseguridad.Location = new System.Drawing.Point(0, 126);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnseguridad.Size = new System.Drawing.Size(250, 39);
            this.btnseguridad.TabIndex = 13;
            this.btnseguridad.Text = "SEGURIDAD";
            this.btnseguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.UseVisualStyleBackColor = false;
            this.btnseguridad.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "GEORGE ISAI MAYÉN RAMÍREZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 37);
            this.label2.TabIndex = 48;
            this.label2.Text = "0901-19-11383";
            // 
            // Menup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSideMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menup";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.Button btnCxP;
        public System.Windows.Forms.Button btnseguridad;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}