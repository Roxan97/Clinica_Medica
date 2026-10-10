
using Clinica_Medica.Modelos;
using Clinica_Medica.Repositorios;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Medica
{
    public partial class frmPaciente : Form
    {
        // ==========================================
        // REPOSITORIOS
        // ==========================================

        private readonly RepositorioGenerico<Pacientes> _pacienteRepo =
            new RepositorioGenerico<Pacientes>();

        private readonly RepositorioGenerico<Generos> _generoRepo =
            new RepositorioGenerico<Generos>();

        private readonly RepositorioGenerico<Especialidades> _especialidadRepo =
            new RepositorioGenerico<Especialidades>();

        // 0 = Nuevo paciente
        // Mayor que 0 = Editar paciente
        private int _idPacienteEditar = 0;

        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public frmPaciente()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += frmPrincipal_KeyDown;

            cmbGenero.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEspecialidad.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dataPacientes.AllowUserToAddRows = false;
            dataPacientes.ReadOnly = true;
            dataPacientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataPacientes.MultiSelect = false;

            // Conectar el evento del botón Editar
            dataPacientes.CellContentClick +=
                dataPacientes_CellContentClick;

            // Crear columna Editar
            AgregarBotonEditar();
        }

        // ==========================================
        // CARGAR FORMULARIO
        // ==========================================

        private async void frmPrincipal_Load(
            object sender, EventArgs e)
        {
            try
            {
                await CargarGenerosAsync();
                await CargarEspecialidadesAsync();
                await CargarPacientesAsync();

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar información: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CARGAR GÉNEROS
        // ==========================================

        private async Task CargarGenerosAsync()
        {
            var generos =
                await _generoRepo.ObtenerTodosAsync();

            cmbGenero.DataSource = generos;
            cmbGenero.DisplayMember = "Nombre";
            cmbGenero.ValueMember = "IdGenero";
            cmbGenero.SelectedIndex = -1;
        }

        // ==========================================
        // CARGAR ESPECIALIDADES ACTIVAS
        // ==========================================

        private async Task CargarEspecialidadesAsync()
        {
            var especialidades =
                await _especialidadRepo.ObtenerTodosAsync();

            cmbEspecialidad.DataSource =
                especialidades
                    .Where(x => x.activo)
                    .ToList();

            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.SelectedIndex = -1;
        }

        // ==========================================
        // CARGAR PACIENTES ACTIVOS
        // ==========================================

        private async Task CargarPacientesAsync()
        {
            var pacientes =
                await _pacienteRepo.ObtenerTodosAsync();

            var generos =
                await _generoRepo.ObtenerTodosAsync();

            var especialidades =
                await _especialidadRepo.ObtenerTodosAsync();

            var listado =
                (from p in pacientes
                 join g in generos
                    on p.IdGenero equals g.IdGenero
                 join e in especialidades
                    on p.IdEspecialidad equals e.IdEspecialidad
                 where p.activo
                 orderby p.IdPaciente descending
                 select new
                 {
                     p.IdPaciente,
                     p.Nombre,
                     p.Apellido,
                     p.Edad,
                     Genero = g.Nombre,
                     Especialidad = e.Nombre
                 }).ToList();

            dataPacientes.DataSource = listado;

            if (dataPacientes.Columns["IdPaciente"] != null)
            {
                dataPacientes.Columns["IdPaciente"].Visible = false;
            }

            AgregarBotonEditar();

            dataPacientes.ClearSelection();
        }

        // ==========================================
        // AGREGAR BOTÓN EDITAR AL DATAGRIDVIEW
        // ==========================================

        private void AgregarBotonEditar()
        {
            if (dataPacientes.Columns["btnEditar"] != null)
                return;

            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acciones";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 85;

            dataPacientes.Columns.Add(btnEditar);
        }

        // ==========================================
        // EVENTO DEL BOTÓN EDITAR
        // ==========================================

        private async void dataPacientes_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataPacientes.Columns[e.ColumnIndex].Name
                != "btnEditar")
                return;

            int idPaciente = Convert.ToInt32(
                dataPacientes.Rows[e.RowIndex]
                    .Cells["IdPaciente"].Value);

            try
            {
                Pacientes paciente =
                    await _pacienteRepo.ObtenerPorIdAsync(idPaciente);

                if (paciente == null || !paciente.activo)
                {
                    MessageBox.Show(
                        "El paciente no existe o está inactivo.");
                    return;
                }

                // Activar modo edición
                _idPacienteEditar = paciente.IdPaciente;

                // Llenar los controles
                txtNombrePaciente.Text = paciente.Nombre;
                txtApellidoPaciente.Text = paciente.Apellido;
                txtEdadPaciente.Text = paciente.Edad.ToString();

                cmbGenero.SelectedValue = paciente.IdGenero;
                cmbEspecialidad.SelectedValue =
                    paciente.IdEspecialidad;

                btnGuardar.Text = "Actualizar paciente";

                txtNombrePaciente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar paciente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // GUARDAR O ACTUALIZAR PACIENTE
        // ==========================================

        private async void btnGuardar_Click(
            object sender, EventArgs e)
        {
            // Validar campos
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
                    MessageBoxIcon.Warning);
                return;
            }

            int edad;

            if (!int.TryParse(txtEdadPaciente.Text, out edad) ||
                edad < 0 || edad > 120)
            {
                MessageBox.Show(
                    "Ingrese una edad válida entre 0 y 120.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnGuardar.Enabled = false;

            try
            {
                if (_idPacienteEditar == 0)
                {
                    // =========================
                    // INSERTAR NUEVO PACIENTE
                    // =========================

                    Pacientes paciente = new Pacientes
                    {
                        Nombre = txtNombrePaciente.Text
                            .Trim().ToUpper(),

                        Apellido = txtApellidoPaciente.Text
                            .Trim().ToUpper(),

                        Edad = edad,

                        IdGenero = Convert.ToInt32(
                            cmbGenero.SelectedValue),

                        IdEspecialidad = Convert.ToInt32(
                            cmbEspecialidad.SelectedValue),

                        activo = true,
                        fecha_creacion = DateTime.Now,
                        fecha_modificacion = null
                    };

                    await _pacienteRepo.InsertarAsync(paciente);

                    MessageBox.Show(
                        "Paciente registrado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // =========================
                    // ACTUALIZAR PACIENTE
                    // =========================

                    Pacientes paciente =
                        await _pacienteRepo.ObtenerPorIdAsync(
                            _idPacienteEditar);

                    if (paciente == null || !paciente.activo)
                    {
                        MessageBox.Show(
                            "El paciente no existe o está inactivo.");
                        return;
                    }

                    paciente.Nombre =
                        txtNombrePaciente.Text.Trim().ToUpper();

                    paciente.Apellido =
                        txtApellidoPaciente.Text.Trim().ToUpper();

                    paciente.Edad = edad;

                    paciente.IdGenero = Convert.ToInt32(
                        cmbGenero.SelectedValue);

                    paciente.IdEspecialidad = Convert.ToInt32(
                        cmbEspecialidad.SelectedValue);

                    // Mantener la fecha de creación original
                    paciente.fecha_modificacion = DateTime.Now;

                    int filas =
                        await _pacienteRepo.ActualizarAsync(paciente);

                    if (filas == 0)
                    {
                        MessageBox.Show(
                            "No se pudo actualizar el paciente.");
                        return;
                    }

                    MessageBox.Show(
                        "Paciente actualizado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // Refrescar tabla
                await CargarPacientesAsync();

                // Regresar al modo nuevo registro
                CancelarEdicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar paciente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        // ==========================================
        // DESACTIVAR PACIENTE CON DOBLE CLIC
        // ==========================================

        private async void dataPacientes_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // No desactivar al presionar Editar
            if (dataPacientes.Columns[e.ColumnIndex].Name
                == "btnEditar")
                return;

            int idPaciente = Convert.ToInt32(
                dataPacientes.Rows[e.RowIndex]
                    .Cells["IdPaciente"].Value);

            DialogResult resultado = MessageBox.Show(
                "¿Desea desactivar este paciente?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                Pacientes paciente =
                    await _pacienteRepo.ObtenerPorIdAsync(idPaciente);

                if (paciente == null || !paciente.activo)
                {
                    MessageBox.Show(
                        "El paciente no existe o está inactivo.");
                    return;
                }

                paciente.activo = false;
                paciente.fecha_modificacion = DateTime.Now;

                int filas =
                    await _pacienteRepo.ActualizarAsync(paciente);

                if (filas > 0)
                {
                    MessageBox.Show(
                        "Paciente desactivado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // Si estaba editando el paciente desactivado
                if (_idPacienteEditar == idPaciente)
                {
                    CancelarEdicion();
                }

                await CargarPacientesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al desactivar paciente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CANCELAR EDICIÓN
        // ==========================================

        private void CancelarEdicion()
        {
            _idPacienteEditar = 0;
            btnGuardar.Text = "Guardar";

            LimpiarCampos();
        }

        // Método para botón Cancelar (si existe)
        private void btnCancelar_Click(
            object sender, EventArgs e)
        {
            CancelarEdicion();
        }

        // ==========================================
        // LIMPIAR CAMPOS
        // ==========================================

        private void LimpiarCampos()
        {
            txtNombrePaciente.Clear();
            txtApellidoPaciente.Clear();
            txtEdadPaciente.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;

            txtNombrePaciente.Focus();
        }

        // ==========================================
        // VALIDAR EDAD
        // ==========================================

        private void txtEdadPaciente_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se permiten números.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // VALIDAR NOMBRE
        // ==========================================

        private void txtNombrePaciente_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(e);
        }

        // ==========================================
        // VALIDAR APELLIDO
        // ==========================================

        private void txtApellidoPaciente_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(e);
        }

        private void ValidarSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se permiten letras.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // ENTER: SIGUIENTE CONTROL
        // ==========================================

        private void frmPrincipal_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SelectNextControl(
                    this.ActiveControl,
                    true, true, true, true);
            }
        }

        // ==========================================
        // EVENTOS EXISTENTES DEL DISEÑADOR
        // ==========================================

        private void dataPacientes_KeyDown(
            object sender, KeyEventArgs e)
        {
        }

        private void label1_Click(
            object sender, EventArgs e)
        {
        }
    }
}
