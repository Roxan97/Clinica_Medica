using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Medica
{
    public partial class frmPaciente : Form
    {
        DataTable pacientes = new DataTable();
        public frmPaciente()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += frmPrincipal_KeyDown;

            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;

            //Llenando los list de los cmbox

            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Otro");

            cmbEspecialidad.Items.Add("Medicina General");
            cmbEspecialidad.Items.Add("Pediatria");
            cmbEspecialidad.Items.Add("Cardiologia");

            //Crear las columnas de la tabla en memoria

            pacientes.Columns.Add("Nombre",typeof(string));
            pacientes.Columns.Add("Apellido", typeof(string));
            pacientes.Columns.Add("Edad", typeof(int));
            pacientes.Columns.Add("Genero", typeof(string));
            pacientes.Columns.Add("Especialidad", typeof(string));

            //Enlazar los datos con el datagridview

            dataPacientes.DataSource = pacientes;

            dataPacientes.AllowUserToAddRows = false;
            dataPacientes.ReadOnly = true;
            dataPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataPacientes.MultiSelect = false;

        }

        private void txtEdadPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*string nombre =txtNombrePaciente.Text;
            string apellido = txtApellidoPaciente.Text;
            string edad = txtEdadPaciente.Text;
            MessageBox.Show($"El nombre ingresado es : {nombre} {apellido} \n Edad: {edad} años", "Informacion Paciente");*/
            try
            {
                // Validar que todos los campos estén llenos
                if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoPaciente.Text) ||
                    string.IsNullOrWhiteSpace(txtEdadPaciente.Text) ||
                    cmbGenero.SelectedIndex == -1 ||
                    cmbEspecialidad.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos.",
                        "Campos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int edad = int.Parse(txtEdadPaciente.Text);

                //Agregar el paciente a la tabla a nivelde memoria

                pacientes.Rows.Add(
                    txtNombrePaciente.Text.Trim().ToUpper(),
                    txtApellidoPaciente.Text.Trim().ToUpper(),
                    edad,
                    cmbGenero.Text.ToUpper(),
                    cmbEspecialidad.Text.ToUpper());

                MessageBox.Show(
                    "Paciente guardado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpiar controles

                txtNombrePaciente.Clear();
                txtApellidoPaciente.Clear();
                txtEdadPaciente.Clear();
                cmbGenero.SelectedIndex = -1;
                cmbEspecialidad.SelectedIndex = -1;



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar el paciente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        
        
        
        
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtNombrePaciente.Text = " ";
            txtApellidoPaciente.Text = " ";

        }

        private void txtApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dataPacientes.Rows[e.RowIndex];

            DialogResult resultado = MessageBox.Show(
                "Desea eliminar este paciente",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resultado == DialogResult.Yes)
            {
                //Eliminar de la tabla en memoria la fila seleccionada
                pacientes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataPacientes_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
