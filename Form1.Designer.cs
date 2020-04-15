namespace Sistema_Prestamista
{
    partial class Home
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServicios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(142, 308);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(221, 87);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "El Prestamista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bienvenido!";
            // 
            // btnServicios
            // 
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Location = new System.Drawing.Point(460, 308);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(221, 87);
            this.btnServicios.TabIndex = 4;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCliente);
            this.Name = "Home";
            this.Text = "Sistema de Prestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServicios;
    }
}

