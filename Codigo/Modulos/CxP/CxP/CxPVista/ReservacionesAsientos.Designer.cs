
namespace CxPVista
{
    partial class ReservacionesAsientos
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
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIdReservación = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdAsiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.txtIdSala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.DimGray;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHelp.IconSize = 40;
            this.btnHelp.Location = new System.Drawing.Point(754, 19);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 61);
            this.btnHelp.TabIndex = 76;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btninsertar);
            this.groupBox2.Controls.Add(this.txtIdFactura);
            this.groupBox2.Controls.Add(this.txtAsiento);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.txtIdReservación);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(17, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 310);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservaciones";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btncancelar.FlatAppearance.BorderSize = 2;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncancelar.IconSize = 40;
            this.btncancelar.Location = new System.Drawing.Point(189, 222);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(69, 61);
            this.btncancelar.TabIndex = 72;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btninsertar.FlatAppearance.BorderSize = 2;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btninsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btninsertar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btninsertar.IconSize = 40;
            this.btninsertar.Location = new System.Drawing.Point(65, 222);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 71;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(528, 95);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(157, 25);
            this.txtIdFactura.TabIndex = 19;
            this.txtIdFactura.Tag = "fkFactura";
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(526, 36);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(159, 25);
            this.txtAsiento.TabIndex = 18;
            this.txtAsiento.Tag = "fkAsientos";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(142, 95);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(159, 25);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.Tag = "subTotalAsiento";
            // 
            // txtIdReservación
            // 
            this.txtIdReservación.Location = new System.Drawing.Point(142, 37);
            this.txtIdReservación.Name = "txtIdReservación";
            this.txtIdReservación.Size = new System.Drawing.Size(159, 25);
            this.txtIdReservación.TabIndex = 16;
            this.txtIdReservación.Tag = "idReservaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "ID Factura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "ID Asiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Subtotal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "ID Reservación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdAsiento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtFila);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtColumna);
            this.groupBox1.Controls.Add(this.txtIdSala);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(17, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 185);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asientos";
            // 
            // txtIdAsiento
            // 
            this.txtIdAsiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtIdAsiento.Location = new System.Drawing.Point(133, 33);
            this.txtIdAsiento.Name = "txtIdAsiento";
            this.txtIdAsiento.Size = new System.Drawing.Size(159, 25);
            this.txtIdAsiento.TabIndex = 20;
            this.txtIdAsiento.Tag = "idAsientos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label11.Location = new System.Drawing.Point(18, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "ID Asiento";
            // 
            // txtFila
            // 
            this.txtFila.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtFila.Location = new System.Drawing.Point(133, 95);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(159, 25);
            this.txtFila.TabIndex = 18;
            this.txtFila.Tag = "Fila";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(15, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fila";
            // 
            // txtColumna
            // 
            this.txtColumna.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtColumna.Location = new System.Drawing.Point(526, 95);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(159, 25);
            this.txtColumna.TabIndex = 14;
            this.txtColumna.Tag = "Columna";
            // 
            // txtIdSala
            // 
            this.txtIdSala.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtIdSala.Location = new System.Drawing.Point(526, 36);
            this.txtIdSala.Name = "txtIdSala";
            this.txtIdSala.Size = new System.Drawing.Size(159, 25);
            this.txtIdSala.TabIndex = 12;
            this.txtIdSala.Tag = "fkSala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label8.Location = new System.Drawing.Point(408, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Columna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(408, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Sala";
            // 
            // ReservacionesAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(92)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReservacionesAsientos";
            this.Text = "ReservacionesAsientos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btninsertar;
        public System.Windows.Forms.TextBox txtIdFactura;
        public System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.TextBox txtIdReservación;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtIdAsiento;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtColumna;
        public System.Windows.Forms.TextBox txtIdSala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}