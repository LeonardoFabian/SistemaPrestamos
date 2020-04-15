namespace Sistema_Prestamista
{
    partial class Servicio
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
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.btnConsultarPrestamo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(297, 330);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(221, 43);
            this.btnEliminarPrestamo.TabIndex = 18;
            this.btnEliminarPrestamo.Text = "Eliminar Prestamo";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrestamo.Location = new System.Drawing.Point(297, 271);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(221, 43);
            this.btnModificarPrestamo.TabIndex = 17;
            this.btnModificarPrestamo.Text = "Modificar Prestamo";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // btnConsultarPrestamo
            // 
            this.btnConsultarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPrestamo.Location = new System.Drawing.Point(297, 212);
            this.btnConsultarPrestamo.Name = "btnConsultarPrestamo";
            this.btnConsultarPrestamo.Size = new System.Drawing.Size(221, 43);
            this.btnConsultarPrestamo.TabIndex = 16;
            this.btnConsultarPrestamo.Text = "Consultar Prestamo";
            this.btnConsultarPrestamo.UseVisualStyleBackColor = true;
            this.btnConsultarPrestamo.Click += new System.EventHandler(this.btnConsultarPrestamo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Servicios";
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(294, 156);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(221, 43);
            this.btnRegistrarPrestamo.TabIndex = 14;
            this.btnRegistrarPrestamo.Text = "Registrar Prestamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "El Prestamista";
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnConsultarPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrarPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Servicio";
            this.Text = "Servicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Button btnConsultarPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}