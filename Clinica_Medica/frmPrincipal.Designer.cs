namespace Clinica_Medica
{
    partial class frmPrincipal
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
            this.lbNombrePaciente = new System.Windows.Forms.Label();
            this.lbApellidoPaciente = new System.Windows.Forms.Label();
            this.lbEdadPaciente = new System.Windows.Forms.Label();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEdadPaciente = new System.Windows.Forms.TextBox();
            this.lbGeneroPaciente = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.panelInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombrePaciente
            // 
            this.lbNombrePaciente.AutoSize = true;
            this.lbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePaciente.Location = new System.Drawing.Point(15, 22);
            this.lbNombrePaciente.Name = "lbNombrePaciente";
            this.lbNombrePaciente.Size = new System.Drawing.Size(112, 16);
            this.lbNombrePaciente.TabIndex = 0;
            this.lbNombrePaciente.Text = "Nombre Paciente";
            // 
            // lbApellidoPaciente
            // 
            this.lbApellidoPaciente.AutoSize = true;
            this.lbApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoPaciente.Location = new System.Drawing.Point(15, 59);
            this.lbApellidoPaciente.Name = "lbApellidoPaciente";
            this.lbApellidoPaciente.Size = new System.Drawing.Size(113, 16);
            this.lbApellidoPaciente.TabIndex = 1;
            this.lbApellidoPaciente.Text = "Apellido Paciente";
            // 
            // lbEdadPaciente
            // 
            this.lbEdadPaciente.AutoSize = true;
            this.lbEdadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdadPaciente.Location = new System.Drawing.Point(15, 100);
            this.lbEdadPaciente.Name = "lbEdadPaciente";
            this.lbEdadPaciente.Size = new System.Drawing.Size(96, 16);
            this.lbEdadPaciente.TabIndex = 2;
            this.lbEdadPaciente.Text = "Edad Paciente";
            // 
            // panelInformacion
            // 
            this.panelInformacion.Controls.Add(this.btnGuardar);
            this.panelInformacion.Controls.Add(this.txtEdadPaciente);
            this.panelInformacion.Controls.Add(this.lbGeneroPaciente);
            this.panelInformacion.Controls.Add(this.rbMasculino);
            this.panelInformacion.Controls.Add(this.rbFemenino);
            this.panelInformacion.Controls.Add(this.txtApellidoPaciente);
            this.panelInformacion.Controls.Add(this.txtNombrePaciente);
            this.panelInformacion.Controls.Add(this.lbNombrePaciente);
            this.panelInformacion.Controls.Add(this.lbEdadPaciente);
            this.panelInformacion.Controls.Add(this.lbApellidoPaciente);
            this.panelInformacion.Location = new System.Drawing.Point(12, 12);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(590, 277);
            this.panelInformacion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(276, 178);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEdadPaciente
            // 
            this.txtEdadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadPaciente.Location = new System.Drawing.Point(202, 94);
            this.txtEdadPaciente.Name = "txtEdadPaciente";
            this.txtEdadPaciente.Size = new System.Drawing.Size(201, 24);
            this.txtEdadPaciente.TabIndex = 8;
            this.txtEdadPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadPaciente_KeyPress);
            // 
            // lbGeneroPaciente
            // 
            this.lbGeneroPaciente.AutoSize = true;
            this.lbGeneroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneroPaciente.Location = new System.Drawing.Point(15, 135);
            this.lbGeneroPaciente.Name = "lbGeneroPaciente";
            this.lbGeneroPaciente.Size = new System.Drawing.Size(108, 16);
            this.lbGeneroPaciente.TabIndex = 7;
            this.lbGeneroPaciente.Text = "Genero Paciente";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(321, 131);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(43, 22);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "M";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(202, 131);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(39, 22);
            this.rbFemenino.TabIndex = 5;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "F";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaciente.Location = new System.Drawing.Point(202, 53);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(201, 24);
            this.txtApellidoPaciente.TabIndex = 4;
            this.txtApellidoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaciente_KeyPress);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(202, 16);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(201, 24);
            this.txtNombrePaciente.TabIndex = 3;
            this.txtNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaciente_KeyPress);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 329);
            this.Controls.Add(this.panelInformacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombrePaciente;
        private System.Windows.Forms.Label lbApellidoPaciente;
        private System.Windows.Forms.Label lbEdadPaciente;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEdadPaciente;
        private System.Windows.Forms.Label lbGeneroPaciente;
    }
}

