
using Clinica_Medica.Modelos;
using Clinica_Medica.Repositorios;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Medica.Formularios
{
    public partial class frmDoctor : Form
    {
        // =====================================
        // REPOSITORIOS
        // =====================================

        private readonly RepositorioGenerico<Doctores> _doctorRepo =
            new RepositorioGenerico<Doctores>();

        private readonly RepositorioGenerico<Especialidades> _especialidadRepo =
            new RepositorioGenerico<Especialidades>();

        // 0 = Nuevo doctor
        // Mayor a 0 = Editar doctor
        private int _idDoctorEditar = 0;

        // =====================================
        // CONSTRUCTOR
        // =====================================

        public frmDoctor()
        {
            InitializeComponent();

            cmbEspecialidad.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dataDoctores.AllowUserToAddRows = false;
            dataDoctores.ReadOnly = true;
            dataDoctores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataDoctores.MultiSelect = false;

            // Evento para editar
            dataDoctores.CellContentClick +=
                dataDoctores_CellContentClick;

            // Evento para desactivar
            dataDoctores.CellDoubleClick +=
                dataDoctores_CellDoubleClick;

            AgregarBotonEditar();
        }

        // =====================================
        // CARGAR FORMULARIO
        // =====================================

        private async void frmDoctor_Load(
            object sender, EventArgs e)
        {
            try
            {
                await CargarEspecialidadesAsync();
                await CargarDoctoresAsync();

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

        // =====================================
        // CARGAR ESPECIALIDADES ACTIVAS
        // =====================================

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

        // =====================================
        // CARGAR DOCTORES ACTIVOS
        // =====================================

        private async Task CargarDoctoresAsync()
        {
            var doctores =
                await _doctorRepo.ObtenerTodosAsync();

            var especialidades =
                await _especialidadRepo.ObtenerTodosAsync();

            var listado =
                (from d in doctores
                 join e in especialidades
                    on d.IdEspecialidad equals e.IdEspecialidad
                 where d.activo
                 orderby d.IdDoctor descending
                 select new
                 {
                     d.IdDoctor,
                     d.Nombre,
                     d.Apellido,
                     Especialidad = e.Nombre
                 }).ToList();

            dataDoctores.DataSource = listado;

            if (dataDoctores.Columns["IdDoctor"] != null)
            {
                dataDoctores.Columns["IdDoctor"].Visible = false;
            }

            AgregarBotonEditar();

            dataDoctores.ClearSelection();
        }

        // =====================================
        // AGREGAR BOTÓN EDITAR
        // =====================================

        private void AgregarBotonEditar()
        {
            if (dataDoctores.Columns["btnEditar"] != null)
                return;

            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acciones";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 85;

            dataDoctores.Columns.Add(btnEditar);
        }

        // =====================================
        // EDITAR DOCTOR DESDE LA GRID
        // =====================================

        private async void dataDoctores_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataDoctores.Columns[e.ColumnIndex].Name
                != "btnEditar")
                return;

            int idDoctor = Convert.ToInt32(
                dataDoctores.Rows[e.RowIndex]
                    .Cells["IdDoctor"].Value);

            try
            {
                Doctores doctor =
                    await _doctorRepo.ObtenerPorIdAsync(idDoctor);

                if (doctor == null || !doctor.activo)
                {
                    MessageBox.Show(
                        "El doctor no existe o está inactivo.");
                    return;
                }

                _idDoctorEditar = doctor.IdDoctor;

                txtNombreDoctor.Text = doctor.Nombre;
                txtApellidoDocente.Text = doctor.Apellido;

                cmbEspecialidad.SelectedValue =
                    doctor.IdEspecialidad;

                btnGuardar.Text = "Actualizar doctor";

                txtNombreDoctor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar doctor: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // GUARDAR O ACTUALIZAR DOCTOR
        // =====================================

        private async void btnGuardar_Click(
            object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreDoctor.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDocente.Text) ||
                cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, complete todos los campos.",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnGuardar.Enabled = false;

            try
            {
                if (_idDoctorEditar == 0)
                {
                    // =========================
                    // INSERTAR NUEVO DOCTOR
                    // =========================

                    Doctores doctor = new Doctores
                    {
                        Nombre = txtNombreDoctor.Text
                            .Trim().ToUpper(),

                        Apellido = txtApellidoDocente.Text
                            .Trim().ToUpper(),

                        IdEspecialidad = Convert.ToInt32(
                            cmbEspecialidad.SelectedValue),

                        activo = true,
                        fecha_creacion = DateTime.Now,
                        fecha_modificacion = null
                    };

                    await _doctorRepo.InsertarAsync(doctor);

                    MessageBox.Show(
                        "Doctor registrado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // =========================
                    // ACTUALIZAR DOCTOR
                    // =========================

                    Doctores doctor =
                        await _doctorRepo.ObtenerPorIdAsync(
                            _idDoctorEditar);

                    if (doctor == null || !doctor.activo)
                    {
                        MessageBox.Show(
                            "El doctor no existe o está inactivo.");
                        return;
                    }

                    doctor.Nombre =
                        txtNombreDoctor.Text.Trim().ToUpper();

                    doctor.Apellido =
                        txtApellidoDocente.Text.Trim().ToUpper();

                    doctor.IdEspecialidad = Convert.ToInt32(
                        cmbEspecialidad.SelectedValue);

                    // Conservar fecha de creación
                    doctor.fecha_modificacion = DateTime.Now;

                    int filas =
                        await _doctorRepo.ActualizarAsync(doctor);

                    if (filas == 0)
                    {
                        MessageBox.Show(
                            "No se pudo actualizar el doctor.");
                        return;
                    }

                    MessageBox.Show(
                        "Doctor actualizado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                await CargarDoctoresAsync();
                CancelarEdicion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar doctor: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        // =====================================
        // DESACTIVAR DOCTOR CON DOBLE CLIC
        // =====================================

        private async void dataDoctores_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Evitar desactivar al presionar Editar
            if (dataDoctores.Columns[e.ColumnIndex].Name
                == "btnEditar")
                return;

            int idDoctor = Convert.ToInt32(
                dataDoctores.Rows[e.RowIndex]
                    .Cells["IdDoctor"].Value);

            DialogResult resultado = MessageBox.Show(
                "¿Desea desactivar este doctor?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                Doctores doctor =
                    await _doctorRepo.ObtenerPorIdAsync(idDoctor);

                if (doctor == null || !doctor.activo)
                {
                    MessageBox.Show(
                        "El doctor no existe o está inactivo.");
                    return;
                }

                doctor.activo = false;
                doctor.fecha_modificacion = DateTime.Now;

                int filas =
                    await _doctorRepo.ActualizarAsync(doctor);

                if (filas > 0)
                {
                    MessageBox.Show(
                        "Doctor desactivado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                if (_idDoctorEditar == idDoctor)
                {
                    CancelarEdicion();
                }

                await CargarDoctoresAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al desactivar doctor: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================
        // CANCELAR EDICIÓN
        // =====================================

        private void CancelarEdicion()
        {
            _idDoctorEditar = 0;
            btnGuardar.Text = "Guardar";

            LimpiarCampos();
        }

        // =====================================
        // LIMPIAR CAMPOS
        // =====================================

        private void LimpiarCampos()
        {
            txtNombreDoctor.Clear();
            txtApellidoDocente.Clear();

            cmbEspecialidad.SelectedIndex = -1;

            txtNombreDoctor.Focus();
        }

        // =====================================
        // VALIDAR SOLO LETRAS
        // =====================================

        private void txtNombreDoctor_KeyPress(
            object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(e);
        }

        private void txtApellidoDocente_KeyPress(
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
            }
        }

        // =====================================
        // EVENTO EXISTENTE
        // =====================================

        private void lbNombrePaciente_Click(
            object sender, EventArgs e)
        {
        }
    }
}
