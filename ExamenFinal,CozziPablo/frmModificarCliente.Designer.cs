namespace ExamenFinal_CozziPablo
{
    partial class frmModificarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Barrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSocio = new System.Windows.Forms.Label();
            this.btnModActividad = new System.Windows.Forms.Button();
            this.btnModBarrio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbActividad);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.txtDeuda);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.Barrio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(43, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 315);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cliente:";
            // 
            // cmbActividad
            // 
            this.cmbActividad.Enabled = false;
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(179, 193);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(268, 28);
            this.cmbActividad.TabIndex = 35;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(179, 137);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(268, 28);
            this.cmbBarrio.TabIndex = 34;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(179, 250);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(268, 26);
            this.txtDeuda.TabIndex = 33;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 93);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(268, 26);
            this.txtDireccion.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 26);
            this.txtNombre.TabIndex = 29;
            // 
            // Barrio
            // 
            this.Barrio.AutoSize = true;
            this.Barrio.Location = new System.Drawing.Point(12, 145);
            this.Barrio.Name = "Barrio";
            this.Barrio.Size = new System.Drawing.Size(55, 20);
            this.Barrio.TabIndex = 28;
            this.Barrio.Text = "Barrio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Actividad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Deuda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Seleccione los datos a modificar de cliente:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(388, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 37);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSocio.Location = new System.Drawing.Point(398, 23);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(113, 31);
            this.lblSocio.TabIndex = 29;
            this.lblSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModActividad
            // 
            this.btnModActividad.Location = new System.Drawing.Point(293, 416);
            this.btnModActividad.Name = "btnModActividad";
            this.btnModActividad.Size = new System.Drawing.Size(197, 37);
            this.btnModActividad.TabIndex = 37;
            this.btnModActividad.Text = "Modificar Actividad";
            this.btnModActividad.UseVisualStyleBackColor = true;
            this.btnModActividad.Click += new System.EventHandler(this.btnModActividad_Click);
            // 
            // btnModBarrio
            // 
            this.btnModBarrio.Location = new System.Drawing.Point(59, 416);
            this.btnModBarrio.Name = "btnModBarrio";
            this.btnModBarrio.Size = new System.Drawing.Size(196, 37);
            this.btnModBarrio.TabIndex = 38;
            this.btnModBarrio.Text = "Modificar Barrio";
            this.btnModBarrio.UseVisualStyleBackColor = true;
            this.btnModBarrio.Click += new System.EventHandler(this.btnModBarrio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 37);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 547);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModBarrio);
            this.Controls.Add(this.btnModActividad);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCliente";
            this.Text = "Modificar cliente:";
            this.Load += new System.EventHandler(this.frmModificarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Barrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Button btnModActividad;
        private System.Windows.Forms.Button btnModBarrio;
        private System.Windows.Forms.Button btnCancelar;
    }
}