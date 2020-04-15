namespace Sistema_Prestamista
{
    partial class frmRegistrarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(18, 89);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(188, 29);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(18, 163);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 29);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(409, 163);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(365, 29);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(18, 228);
            this.txtFechaNacimiento.MaxLength = 25;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(188, 29);
            this.txtFechaNacimiento.TabIndex = 8;
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Nacimiento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(20, 302);
            this.txtTelefono.MaxLength = 24;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 29);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Télefono";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(235, 302);
            this.txtCorreo.MaxLength = 80;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(539, 29);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Correo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(233, 228);
            this.txtGenero.MaxLength = 1;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(51, 29);
            this.txtGenero.TabIndex = 14;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Género";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(22, 372);
            this.txtDireccion.MaxLength = 80;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(754, 29);
            this.txtDireccion.TabIndex = 16;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dirección";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(553, 419);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(221, 43);
            this.btnRegistrarCliente.TabIndex = 18;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(17, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "DD/MM/AAAA";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(19, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ej.: 00117910058";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(232, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "M / F";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(19, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ej.: 8095555555";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarCliente";
            this.Text = "frmRegistrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}