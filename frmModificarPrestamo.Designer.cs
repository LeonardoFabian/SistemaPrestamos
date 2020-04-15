namespace Sistema_Prestamista
{
    partial class frmModificarPrestamo
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
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtTipoTransaccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarPrestamo = new System.Windows.Forms.Button();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCuotasPendientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNP = new System.Windows.Forms.Label();
            this.lblNumeroPrestamo = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblBalanceActual = new System.Windows.Forms.Label();
            this.lblBalanceInicial = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvDetalleTransacciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Enabled = false;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(629, 70);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 29);
            this.btnLimpiarCampos.TabIndex = 76;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(432, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Ej.: 00117910058";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(566, 439);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(221, 43);
            this.btnGuardarCambios.TabIndex = 67;
            this.btnGuardarCambios.Text = "Realizar Transacción";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoTransaccion.Location = new System.Drawing.Point(566, 395);
            this.txtTipoTransaccion.MaxLength = 80;
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Size = new System.Drawing.Size(221, 29);
            this.txtTipoTransaccion.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Tipo Transaccion";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(566, 333);
            this.txtMonto.MaxLength = 24;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(221, 29);
            this.txtMonto.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Modificar Prestamo";
            // 
            // btnConsultarPrestamo
            // 
            this.btnConsultarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPrestamo.Location = new System.Drawing.Point(629, 35);
            this.btnConsultarPrestamo.Name = "btnConsultarPrestamo";
            this.btnConsultarPrestamo.Size = new System.Drawing.Size(154, 29);
            this.btnConsultarPrestamo.TabIndex = 79;
            this.btnConsultarPrestamo.Text = "Consultar";
            this.btnConsultarPrestamo.UseVisualStyleBackColor = true;
            this.btnConsultarPrestamo.Click += new System.EventHandler(this.btnConsultarPrestamo_Click);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(435, 35);
            this.txtNumeroCuenta.MaxLength = 11;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(188, 29);
            this.txtNumeroCuenta.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(430, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 77;
            this.label14.Text = "Prestamo No.";
            // 
            // lblCuotasPendientes
            // 
            this.lblCuotasPendientes.AutoSize = true;
            this.lblCuotasPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotasPendientes.Location = new System.Drawing.Point(616, 173);
            this.lblCuotasPendientes.Name = "lblCuotasPendientes";
            this.lblCuotasPendientes.Size = new System.Drawing.Size(16, 17);
            this.lblCuotasPendientes.TabIndex = 92;
            this.lblCuotasPendientes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 91;
            this.label3.Text = "Cuotas Pendientes";
            // 
            // labelNP
            // 
            this.labelNP.AutoSize = true;
            this.labelNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNP.Location = new System.Drawing.Point(21, 82);
            this.labelNP.Name = "labelNP";
            this.labelNP.Size = new System.Drawing.Size(114, 17);
            this.labelNP.TabIndex = 90;
            this.labelNP.Text = "No. de Prestamo";
            this.labelNP.Visible = false;
            // 
            // lblNumeroPrestamo
            // 
            this.lblNumeroPrestamo.AutoSize = true;
            this.lblNumeroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPrestamo.Location = new System.Drawing.Point(22, 99);
            this.lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            this.lblNumeroPrestamo.Size = new System.Drawing.Size(20, 24);
            this.lblNumeroPrestamo.TabIndex = 89;
            this.lblNumeroPrestamo.Text = "0";
            this.lblNumeroPrestamo.Visible = false;
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(474, 175);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(36, 17);
            this.lblCuotaMensual.TabIndex = 88;
            this.lblCuotaMensual.Text = "0.00";
            // 
            // lblBalanceActual
            // 
            this.lblBalanceActual.AutoSize = true;
            this.lblBalanceActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceActual.Location = new System.Drawing.Point(276, 175);
            this.lblBalanceActual.Name = "lblBalanceActual";
            this.lblBalanceActual.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceActual.TabIndex = 87;
            this.lblBalanceActual.Text = "0.00";
            // 
            // lblBalanceInicial
            // 
            this.lblBalanceInicial.AutoSize = true;
            this.lblBalanceInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceInicial.Location = new System.Drawing.Point(63, 175);
            this.lblBalanceInicial.Name = "lblBalanceInicial";
            this.lblBalanceInicial.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceInicial.TabIndex = 86;
            this.lblBalanceInicial.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "RD$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "RD$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "RD$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Cuota Mensual";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(233, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 24);
            this.label12.TabIndex = 81;
            this.label12.Text = "Balance Actual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 80;
            this.label15.Text = "Balance Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "Información de Transacciones";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 24);
            this.label16.TabIndex = 94;
            this.label16.Text = "Transacciones";
            // 
            // dgvDetalleTransacciones
            // 
            this.dgvDetalleTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTransacciones.Location = new System.Drawing.Point(24, 285);
            this.dgvDetalleTransacciones.Name = "dgvDetalleTransacciones";
            this.dgvDetalleTransacciones.Size = new System.Drawing.Size(518, 197);
            this.dgvDetalleTransacciones.TabIndex = 93;
            this.dgvDetalleTransacciones.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Debito - Credito";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 24);
            this.label13.TabIndex = 96;
            this.label13.Text = "Realizar Transacción";
            // 
            // frmModificarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvDetalleTransacciones);
            this.Controls.Add(this.lblCuotasPendientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNP);
            this.Controls.Add(this.lblNumeroPrestamo);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.lblBalanceActual);
            this.Controls.Add(this.lblBalanceInicial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnConsultarPrestamo);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtTipoTransaccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarPrestamo";
            this.Text = "frmModificarPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtTipoTransaccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPrestamo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCuotasPendientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNP;
        private System.Windows.Forms.Label lblNumeroPrestamo;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblBalanceActual;
        private System.Windows.Forms.Label lblBalanceInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvDetalleTransacciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}