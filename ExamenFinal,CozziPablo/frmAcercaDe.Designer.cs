namespace ExamenFinal_CozziPablo
{
    partial class frmAcercaDe
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
            this.grpFacultad = new System.Windows.Forms.GroupBox();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.grpFacultad.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFacultad
            // 
            this.grpFacultad.Controls.Add(this.lblTrabajo);
            this.grpFacultad.Controls.Add(this.lblCarrera);
            this.grpFacultad.Controls.Add(this.lblMateria);
            this.grpFacultad.Location = new System.Drawing.Point(45, 233);
            this.grpFacultad.Name = "grpFacultad";
            this.grpFacultad.Size = new System.Drawing.Size(593, 198);
            this.grpFacultad.TabIndex = 9;
            this.grpFacultad.TabStop = false;
            this.grpFacultad.Text = "Datos Academicos";
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajo.Location = new System.Drawing.Point(16, 138);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(247, 38);
            this.lblTrabajo.TabIndex = 4;
            this.lblTrabajo.Text = "* Examen Final";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(15, 40);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(559, 37);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "Analista de Sistemas de Computacion";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(16, 96);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(423, 32);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "* Laboratorio de Programacion 2";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblDni);
            this.grpDatos.Controls.Add(this.lblNombreApellido);
            this.grpDatos.Location = new System.Drawing.Point(45, 20);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(593, 149);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del alumno";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(146, 81);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(232, 37);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI: 39693913";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(103, 35);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(336, 37);
            this.lblNombreApellido.TabIndex = 1;
            this.lblNombreApellido.Text = "Cozzi, Pablo Ezqeuiel.";
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.grpFacultad);
            this.Controls.Add(this.grpDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de...";
            this.grpFacultad.ResumeLayout(false);
            this.grpFacultad.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFacultad;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreApellido;
    }
}