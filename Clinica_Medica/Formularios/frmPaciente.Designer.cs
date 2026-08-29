namespace Clinica_Medica
{
    partial class frmPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEdadPaciente = new System.Windows.Forms.TextBox();
            this.lbGeneroPaciente = new System.Windows.Forms.Label();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPacientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataPacientes = new System.Windows.Forms.DataGridView();
            this.panelInformacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPacientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombrePaciente
            // 
            this.lbNombrePaciente.AutoSize = true;
            this.lbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePaciente.Location = new System.Drawing.Point(84, 26);
            this.lbNombrePaciente.Name = "lbNombrePaciente";
            this.lbNombrePaciente.Size = new System.Drawing.Size(123, 18);
            this.lbNombrePaciente.TabIndex = 0;
            this.lbNombrePaciente.Text = "Nombre Paciente";
            // 
            // lbApellidoPaciente
            // 
            this.lbApellidoPaciente.AutoSize = true;
            this.lbApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoPaciente.Location = new System.Drawing.Point(84, 63);
            this.lbApellidoPaciente.Name = "lbApellidoPaciente";
            this.lbApellidoPaciente.Size = new System.Drawing.Size(120, 18);
            this.lbApellidoPaciente.TabIndex = 1;
            this.lbApellidoPaciente.Text = "Apellido Paciente";
            // 
            // lbEdadPaciente
            // 
            this.lbEdadPaciente.AutoSize = true;
            this.lbEdadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdadPaciente.Location = new System.Drawing.Point(84, 104);
            this.lbEdadPaciente.Name = "lbEdadPaciente";
            this.lbEdadPaciente.Size = new System.Drawing.Size(103, 18);
            this.lbEdadPaciente.TabIndex = 2;
            this.lbEdadPaciente.Text = "Edad Paciente";
            // 
            // panelInformacion
            // 
            this.panelInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInformacion.Controls.Add(this.label1);
            this.panelInformacion.Controls.Add(this.cmbEspecialidad);
            this.panelInformacion.Controls.Add(this.cmbGenero);
            this.panelInformacion.Controls.Add(this.btnGuardar);
            this.panelInformacion.Controls.Add(this.txtEdadPaciente);
            this.panelInformacion.Controls.Add(this.lbGeneroPaciente);
            this.panelInformacion.Controls.Add(this.txtApellidoPaciente);
            this.panelInformacion.Controls.Add(this.txtNombrePaciente);
            this.panelInformacion.Controls.Add(this.lbNombrePaciente);
            this.panelInformacion.Controls.Add(this.lbEdadPaciente);
            this.panelInformacion.Controls.Add(this.lbApellidoPaciente);
            this.panelInformacion.Location = new System.Drawing.Point(12, 12);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(868, 284);
            this.panelInformacion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Especialidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(271, 174);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(417, 24);
            this.cmbEspecialidad.TabIndex = 11;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(271, 136);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(417, 24);
            this.cmbGenero.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(398, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEdadPaciente
            // 
            this.txtEdadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadPaciente.Location = new System.Drawing.Point(271, 98);
            this.txtEdadPaciente.Name = "txtEdadPaciente";
            this.txtEdadPaciente.Size = new System.Drawing.Size(417, 24);
            this.txtEdadPaciente.TabIndex = 8;
            this.txtEdadPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadPaciente_KeyPress);
            // 
            // lbGeneroPaciente
            // 
            this.lbGeneroPaciente.AutoSize = true;
            this.lbGeneroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneroPaciente.Location = new System.Drawing.Point(84, 139);
            this.lbGeneroPaciente.Name = "lbGeneroPaciente";
            this.lbGeneroPaciente.Size = new System.Drawing.Size(119, 18);
            this.lbGeneroPaciente.TabIndex = 7;
            this.lbGeneroPaciente.Text = "Genero Paciente";
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaciente.Location = new System.Drawing.Point(271, 57);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(417, 24);
            this.txtApellidoPaciente.TabIndex = 4;
            this.txtApellidoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaciente_KeyPress);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(271, 20);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(417, 24);
            this.txtNombrePaciente.TabIndex = 3;
            this.txtNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaciente_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabPacientes);
            this.panel1.Location = new System.Drawing.Point(13, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 260);
            this.panel1.TabIndex = 4;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Controls.Add(this.tabPage1);
            this.tabPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPacientes.Location = new System.Drawing.Point(0, 0);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.SelectedIndex = 0;
            this.tabPacientes.Size = new System.Drawing.Size(867, 260);
            this.tabPacientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataPacientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataPacientes
            // 
            this.dataPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPacientes.Location = new System.Drawing.Point(3, 3);
            this.dataPacientes.Name = "dataPacientes";
            this.dataPacientes.RowHeadersWidth = 51;
            this.dataPacientes.RowTemplate.Height = 24;
            this.dataPacientes.Size = new System.Drawing.Size(853, 225);
            this.dataPacientes.TabIndex = 0;
            this.dataPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPacientes_CellDoubleClick);
            this.dataPacientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataPacientes_KeyDown);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInformacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Paciente";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPacientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombrePaciente;
        private System.Windows.Forms.Label lbApellidoPaciente;
        private System.Windows.Forms.Label lbEdadPaciente;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEdadPaciente;
        private System.Windows.Forms.Label lbGeneroPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabPacientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataPacientes;
    }
}

