namespace Clinica_Medica.Formularios
{
    partial class frmDoctor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPacientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataDoctores = new System.Windows.Forms.DataGridView();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.lbNombreDoctor = new System.Windows.Forms.Label();
            this.lbApellidoDoctor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPacientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctores)).BeginInit();
            this.panelInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabPacientes);
            this.panel1.Location = new System.Drawing.Point(11, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 192);
            this.panel1.TabIndex = 6;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Controls.Add(this.tabPage1);
            this.tabPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPacientes.Location = new System.Drawing.Point(0, 0);
            this.tabPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.SelectedIndex = 0;
            this.tabPacientes.Size = new System.Drawing.Size(718, 192);
            this.tabPacientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataDoctores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(710, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataDoctores
            // 
            this.dataDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoctores.Location = new System.Drawing.Point(2, 2);
            this.dataDoctores.Margin = new System.Windows.Forms.Padding(2);
            this.dataDoctores.Name = "dataDoctores";
            this.dataDoctores.RowHeadersWidth = 51;
            this.dataDoctores.RowTemplate.Height = 24;
            this.dataDoctores.Size = new System.Drawing.Size(706, 162);
            this.dataDoctores.TabIndex = 0;
            // 
            // panelInformacion
            // 
            this.panelInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInformacion.Controls.Add(this.cmbEspecialidad);
            this.panelInformacion.Controls.Add(this.btnGuardar);
            this.panelInformacion.Controls.Add(this.lbEspecialidad);
            this.panelInformacion.Controls.Add(this.txtApellidoDocente);
            this.panelInformacion.Controls.Add(this.txtNombreDoctor);
            this.panelInformacion.Controls.Add(this.lbNombreDoctor);
            this.panelInformacion.Controls.Add(this.lbApellidoDoctor);
            this.panelInformacion.Location = new System.Drawing.Point(11, 11);
            this.panelInformacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(718, 197);
            this.panelInformacion.TabIndex = 5;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(203, 81);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(314, 21);
            this.cmbEspecialidad.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(301, 144);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 27);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.AutoSize = true;
            this.lbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecialidad.Location = new System.Drawing.Point(63, 84);
            this.lbEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(78, 15);
            this.lbEspecialidad.TabIndex = 7;
            this.lbEspecialidad.Text = "Especialidad";
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDocente.Location = new System.Drawing.Point(203, 46);
            this.txtApellidoDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(314, 20);
            this.txtApellidoDocente.TabIndex = 4;
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoctor.Location = new System.Drawing.Point(203, 16);
            this.txtNombreDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(314, 20);
            this.txtNombreDoctor.TabIndex = 3;
            // 
            // lbNombreDoctor
            // 
            this.lbNombreDoctor.AutoSize = true;
            this.lbNombreDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDoctor.Location = new System.Drawing.Point(63, 21);
            this.lbNombreDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombreDoctor.Name = "lbNombreDoctor";
            this.lbNombreDoctor.Size = new System.Drawing.Size(91, 15);
            this.lbNombreDoctor.TabIndex = 0;
            this.lbNombreDoctor.Text = "Nombre Doctor";
            this.lbNombreDoctor.Click += new System.EventHandler(this.lbNombrePaciente_Click);
            // 
            // lbApellidoDoctor
            // 
            this.lbApellidoDoctor.AutoSize = true;
            this.lbApellidoDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoDoctor.Location = new System.Drawing.Point(63, 51);
            this.lbApellidoDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellidoDoctor.Name = "lbApellidoDoctor";
            this.lbApellidoDoctor.Size = new System.Drawing.Size(90, 15);
            this.lbApellidoDoctor.TabIndex = 1;
            this.lbApellidoDoctor.Text = "Apellido Doctor";
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInformacion);
            this.Name = "frmDoctor";
            this.Text = "frmDoctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.panel1.ResumeLayout(false);
            this.tabPacientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctores)).EndInit();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label lbNombreDoctor;
        private System.Windows.Forms.Label lbApellidoDoctor;
        private System.Windows.Forms.TabControl tabPacientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataDoctores;
    }
}