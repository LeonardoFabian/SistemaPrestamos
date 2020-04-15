namespace Sistema_Prestamista
{
    partial class frmConsultarCliente
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
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetallesPrestamos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBalanceInicial = new System.Windows.Forms.Label();
            this.lblBalanceActual = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(631, 29);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(154, 29);
            this.btnConsultarCliente.TabIndex = 22;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(437, 29);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(188, 29);
            this.txtCedula.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Consultar Cliente";
            // 
            // dgvDetallesPrestamos
            // 
            this.dgvDetallesPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPrestamos.Location = new System.Drawing.Point(22, 252);
            this.dgvDetallesPrestamos.Name = "dgvDetallesPrestamos";
            this.dgvDetallesPrestamos.Size = new System.Drawing.Size(763, 74);
            this.dgvDetallesPrestamos.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(433, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Préstamos";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(434, 97);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 17);
            this.lblCedula.TabIndex = 26;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Balance total Préstamos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Balance Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Balance Actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cuota Mensual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "RD$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "RD$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "RD$";
            // 
            // lblBalanceInicial
            // 
            this.lblBalanceInicial.AutoSize = true;
            this.lblBalanceInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceInicial.Location = new System.Drawing.Point(65, 208);
            this.lblBalanceInicial.Name = "lblBalanceInicial";
            this.lblBalanceInicial.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceInicial.TabIndex = 34;
            this.lblBalanceInicial.Text = "0.00";
            // 
            // lblBalanceActual
            // 
            this.lblBalanceActual.AutoSize = true;
            this.lblBalanceActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceActual.Location = new System.Drawing.Point(278, 208);
            this.lblBalanceActual.Name = "lblBalanceActual";
            this.lblBalanceActual.Size = new System.Drawing.Size(36, 17);
            this.lblBalanceActual.TabIndex = 35;
            this.lblBalanceActual.Text = "0.00";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(476, 208);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(36, 17);
            this.lblCuotaMensual.TabIndex = 36;
            this.lblCuotaMensual.Text = "0.00";
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.dgvDetallesPrestamos);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarCliente";
            this.Text = "frmConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetallesPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBalanceInicial;
        private System.Windows.Forms.Label lblBalanceActual;
        private System.Windows.Forms.Label lblCuotaMensual;
    }
}