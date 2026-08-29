using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Medica.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CerrarFormularioActivo()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }


        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            Form FrmOpen = Application.OpenForms["frmPaciente"];
            if (FrmOpen == null)
            {
                frmPaciente Frm = new frmPaciente();
                Frm.MdiParent = this;
                Frm.WindowState = FormWindowState.Maximized;
                Frm.Show();
            }

        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            Form FrmOpen = Application.OpenForms["frmConsulta"];
            if (FrmOpen == null)
            {
                frmConsulta Frm = new frmConsulta();
                Frm.MdiParent = this;
                Frm.WindowState = FormWindowState.Maximized;
                Frm.Show();
            }

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
