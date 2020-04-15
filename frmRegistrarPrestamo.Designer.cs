namespace Sistema_Prestamista
{
    partial class frmRegistrarPrestamo
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
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuentaNumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClienteid = new System.Windows.Forms.Label();
            this.lblEstatusCliente = new System.Windows.Forms.Label();
            this.btnConsultarNumeroCuenta = new System.Windows.Forms.Button();
            this.lblCuentaRecomendada = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCuota = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.labelTasa = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(219, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Meses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(219, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Personal, Hipotecario o Vehiculo";
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Enabled = false;
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(559, 511);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(221, 53);
            this.btnRegistrarPrestamo.TabIndex = 41;
            this.btnRegistrarPrestamo.Text = "Aprobar";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazo.Location = new System.Drawing.Point(222, 411);
            this.txtPlazo.MaxLength = 25;
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(386, 29);
            this.txtPlazo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Plazo";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(280, 284);
            this.txtMonto.MaxLength = 50;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(328, 29);
            this.txtMonto.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Monto solicitado";
            // 
            // txtTipoPrestamo
            // 
            this.txtTipoPrestamo.Enabled = false;
            this.txtTipoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPrestamo.Location = new System.Drawing.Point(222, 347);
            this.txtTipoPrestamo.MaxLength = 50;
            this.txtTipoPrestamo.Name = "txtTipoPrestamo";
            this.txtTipoPrestamo.Size = new System.Drawing.Size(386, 29);
            this.txtTipoPrestamo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo de prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registrar Prestamo";
            // 
            // txtCuentaNumero
            // 
            this.txtCuentaNumero.Enabled = false;
            this.txtCuentaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaNumero.Location = new System.Drawing.Point(222, 227);
            this.txtCuentaNumero.MaxLength = 11;
            this.txtCuentaNumero.Name = "txtCuentaNumero";
            this.txtCuentaNumero.Size = new System.Drawing.Size(386, 29);
            this.txtCuentaNumero.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "Número de cuenta";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Enabled = false;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(188, 125);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 29);
            this.btnLimpiarCampos.TabIndex = 82;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(28, 125);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(154, 29);
            this.btnBuscarCliente.TabIndex = 81;
            this.btnBuscarCliente.Text = "Consultar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(28, 90);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(314, 29);
            this.txtCedula.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Cédula";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(91, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Ej.: 00117910058";
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje1.Location = new System.Drawing.Point(25, 157);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(303, 15);
            this.lblMensaje1.TabIndex = 83;
            this.lblMensaje1.Text = "El cliente debe haber sido registrado previamente y no";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(70, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 84;
            this.label17.Text = "*";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje2.Location = new System.Drawing.Point(25, 172);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(318, 15);
            this.lblMensaje2.TabIndex = 85;
            this.lblMensaje2.Text = "poseer prestamos del mismo tipo con balance pendiente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(487, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 86;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblClienteid
            // 
            this.lblClienteid.AutoSize = true;
            this.lblClienteid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteid.Location = new System.Drawing.Point(487, 48);
            this.lblClienteid.Name = "lblClienteid";
            this.lblClienteid.Size = new System.Drawing.Size(21, 17);
            this.lblClienteid.TabIndex = 87;
            this.lblClienteid.Text = "ID";
            this.lblClienteid.Visible = false;
            // 
            // lblEstatusCliente
            // 
            this.lblEstatusCliente.AutoSize = true;
            this.lblEstatusCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusCliente.ForeColor = System.Drawing.Color.Red;
            this.lblEstatusCliente.Location = new System.Drawing.Point(487, 70);
            this.lblEstatusCliente.Name = "lblEstatusCliente";
            this.lblEstatusCliente.Size = new System.Drawing.Size(81, 15);
            this.lblEstatusCliente.TabIndex = 88;
            this.lblEstatusCliente.Text = "No registrado";
            this.lblEstatusCliente.Visible = false;
            // 
            // btnConsultarNumeroCuenta
            // 
            this.btnConsultarNumeroCuenta.Enabled = false;
            this.btnConsultarNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNumeroCuenta.Location = new System.Drawing.Point(626, 229);
            this.btnConsultarNumeroCuenta.Name = "btnConsultarNumeroCuenta";
            this.btnConsultarNumeroCuenta.Size = new System.Drawing.Size(154, 29);
            this.btnConsultarNumeroCuenta.TabIndex = 89;
            this.btnConsultarNumeroCuenta.Text = "Consultar";
            this.btnConsultarNumeroCuenta.UseVisualStyleBackColor = true;
            this.btnConsultarNumeroCuenta.Click += new System.EventHandler(this.btnConsultarNumeroCuenta_Click);
            // 
            // lblCuentaRecomendada
            // 
            this.lblCuentaRecomendada.AutoSize = true;
            this.lblCuentaRecomendada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaRecomendada.ForeColor = System.Drawing.Color.Red;
            this.lblCuentaRecomendada.Location = new System.Drawing.Point(487, 90);
            this.lblCuentaRecomendada.Name = "lblCuentaRecomendada";
            this.lblCuentaRecomendada.Size = new System.Drawing.Size(132, 15);
            this.lblCuentaRecomendada.TabIndex = 90;
            this.lblCuentaRecomendada.Text = "Numero recomendado";
            this.lblCuentaRecomendada.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCuentaRecomendada.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(219, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Ej.: 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "RD$";
            // 
            // labelCuota
            // 
            this.labelCuota.AutoSize = true;
            this.labelCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota.Location = new System.Drawing.Point(25, 511);
            this.labelCuota.Name = "labelCuota";
            this.labelCuota.Size = new System.Drawing.Size(106, 17);
            this.labelCuota.TabIndex = 92;
            this.labelCuota.Text = "Cuota mensual:";
            this.labelCuota.Visible = false;
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(149, 511);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(36, 17);
            this.lblCuotaMensual.TabIndex = 93;
            this.lblCuotaMensual.Text = "0.00";
            this.lblCuotaMensual.Visible = false;
            // 
            // labelTasa
            // 
            this.labelTasa.AutoSize = true;
            this.labelTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasa.Location = new System.Drawing.Point(25, 535);
            this.labelTasa.Name = "labelTasa";
            this.labelTasa.Size = new System.Drawing.Size(60, 17);
            this.labelTasa.TabIndex = 94;
            this.labelTasa.Text = "% Tasa:";
            this.labelTasa.Visible = false;
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.Location = new System.Drawing.Point(149, 535);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(36, 17);
            this.lblTasa.TabIndex = 95;
            this.lblTasa.Text = "15.0";
            this.lblTasa.Visible = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Enabled = false;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(332, 511);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(221, 53);
            this.btnValidar.TabIndex = 96;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // frmRegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.labelTasa);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.labelCuota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCuentaRecomendada);
            this.Controls.Add(this.btnConsultarNumeroCuenta);
            this.Controls.Add(this.lblEstatusCliente);
            this.Controls.Add(this.lblClienteid);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblMensaje1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCuentaNumero);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegistrarPrestamo);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarPrestamo";
            this.Text = "frmRegistrarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuentaNumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClienteid;
        private System.Windows.Forms.Label lblEstatusCliente;
        private System.Windows.Forms.Button btnConsultarNumeroCuenta;
        private System.Windows.Forms.Label lblCuentaRecomendada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCuota;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label labelTasa;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Button btnValidar;
    }
}