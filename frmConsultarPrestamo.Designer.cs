namespace Sistema_Prestamista
{
    partial class frmConsultarPrestamo
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
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblBalanceActual = new System.Windows.Forms.Label();
            this.lblBalanceInicial = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDetalleTransacciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarPrestamo = new System.Windows.Forms.Button();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNumeroPrestamo = new System.Windows.Forms.Label();
            this.labelNP = new System.Windows.Forms.Label();
            this.lblCuotasPendientes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(476, 283);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(36, 17);
            this.lblCuotaMensual.TabIndex = 54;
            this.lblCuotaMensual.Text = "0.00";
            // 
            // lblBalanceActual
            // 
            this.lblBalanceActual.AutoSize = true;
            this.lblBalanceActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceActual.Location = new System.Drawing.Point(278, 283);
            this.lblBalanceActual.Name = "lblBalanceActual";
            this.lblBalanceActual.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceActual.TabIndex = 53;
            this.lblBalanceActual.Text = "0.00";
            // 
            // lblBalanceInicial
            // 
            this.lblBalanceInicial.AutoSize = true;
            this.lblBalanceInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceInicial.Location = new System.Drawing.Point(65, 283);
            this.lblBalanceInicial.Name = "lblBalanceInicial";
            this.lblBalanceInicial.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceInicial.TabIndex = 52;
            this.lblBalanceInicial.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "RD$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "RD$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "RD$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cuota Mensual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Balance Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Balance Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Balance total Préstamos";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(432, 139);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 17);
            this.lblCedula.TabIndex = 44;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Préstamos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(431, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // dgvDetalleTransacciones
            // 
            this.dgvDetalleTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTransacciones.Location = new System.Drawing.Point(22, 381);
            this.dgvDetalleTransacciones.Name = "dgvDetalleTransacciones";
            this.dgvDetalleTransacciones.Size = new System.Drawing.Size(763, 136);
            this.dgvDetalleTransacciones.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Consultar Prestamo";
            // 
            // btnConsultarPrestamo
            // 
            this.btnConsultarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPrestamo.Location = new System.Drawing.Point(631, 50);
            this.btnConsultarPrestamo.Name = "btnConsultarPrestamo";
            this.btnConsultarPrestamo.Size = new System.Drawing.Size(154, 29);
            this.btnConsultarPrestamo.TabIndex = 57;
            this.btnConsultarPrestamo.Text = "Consultar";
            this.btnConsultarPrestamo.UseVisualStyleBackColor = true;
            this.btnConsultarPrestamo.Click += new System.EventHandler(this.btnConsultarPrestamo_Click);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(437, 50);
            this.txtNumeroCuenta.MaxLength = 11;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(188, 29);
            this.txtNumeroCuenta.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Prestamo No.";
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.AutoSize = true;
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(433, 199);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(20, 24);
            this.lblNumeroPrestamo.TabIndex = 58;
            this.lblNumeroPrestamo.Text = "0";
            this.lblNumeroPrestamo.Visible = false;
            // 
            // labelNP
            // 
            this.labelNP.AutoSize = true;
            this.labelNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNP.Location = new System.Drawing.Point(432, 182);
            this.labelNP.Name = "labelNP";
            this.labelNP.Size = new System.Drawing.Size(114, 17);
            this.labelNP.TabIndex = 59;
            this.labelNP.Text = "No. de Prestamo";
            this.labelNP.Visible = false;
            // 
            // lblCuotasPendientes
            // 
            this.lblCuotasPendientes.AutoSize = true;
            this.lblCuotasPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotasPendientes.Location = new System.Drawing.Point(618, 281);
            this.lblCuotasPendientes.Name = "lblCuotasPendientes";
            this.lblCuotasPendientes.Size = new System.Drawing.Size(16, 17);
            this.lblCuotasPendientes.TabIndex = 62;
            this.lblCuotasPendientes.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(617, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 24);
            this.label13.TabIndex = 60;
            this.label13.Text = "Cuotas Pendientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Información de Transacciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 24);
            this.label12.TabIndex = 63;
            this.label12.Text = "Transacciones";
            // 
            // frmConsultarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCuotasPendientes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelNP);
            this.Controls.Add(this.lblNumeroPrestamo);
            this.Controls.Add(this.btnConsultarPrestamo);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.lblBalanceActual);
            this.Controls.Add(this.lblBalanceInicial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDetalleTransacciones);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarPrestamo";
            this.Text = "Transacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblBalanceActual;
        private System.Windows.Forms.Label lblBalanceInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvDetalleTransacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPrestamo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNumeroPrestamo;
        private System.Windows.Forms.Label labelNP;
        private System.Windows.Forms.Label lblCuotasPendientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}