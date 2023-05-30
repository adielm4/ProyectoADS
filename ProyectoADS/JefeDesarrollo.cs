using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class JefeDesarrollo : Form
    {
        CRUD consultas = new CRUD();
        Validaciones validar = new Validaciones();
        int logueado = 0;
        string departamento;
        string fechasoli;
        int estado = 0;
        public JefeDesarrollo(int idUsuarioLogueado)
        {
            InitializeComponent();
            logueado = idUsuarioLogueado;
        }

        public void verSolicitudes()
        {
            dgvSolicitud.DataSource = null;
            dgvSolicitud.DataSource = consultas.VerSolicitudesIDJefeDesarrollo(logueado);
            dgvSolicitud.Columns["id_estado"].Visible = false;
            dgvSolicitudes.DataSource = null;
            dgvSolicitudes.DataSource = consultas.VerSolicitudesIDJefeDesarrollo(logueado);
            dgvSolicitudes.Columns["id_estado"].Visible = false;
        }

        public void verProgramadores()
        {
            cmboProgramador.DisplayMember = "nombre";
            cmboProgramador.ValueMember = "id";
            cmboProgramador.DataSource = consultas.verProgramadores();
        }

        public void verTester()
        {
            cmboTester.DisplayMember = "nombre";
            cmboTester.ValueMember = "id";
            cmboTester.DataSource = consultas.verTester();
        }

        public string GenerarCodigo()
        {
            string codigo = "";
            string[] splitDepa;
            splitDepa = departamento.Split(' ');

            codigo = splitDepa[0].Substring(0, 1).ToUpper() + splitDepa[2].Substring(0, 1).ToUpper() + fechasoli.Replace("/", "") + GenerateRandomNo();
            return codigo;
        }

        public int GenerateRandomNo()
        {
            int min = 100;
            int max = 999;
            Random rdm = new Random();
            return rdm.Next(min, max);
        }

        private void JefeDesarrollo_Load(object sender, EventArgs e)
        {
            verSolicitudes();
            verTester();
            verProgramadores();
            VerCasos();
        }

        public void limpiar()
        {
            txtIDAceptar.Clear();
            txtDescripcion.Clear();
        }

        public void VerCasos()
        {
            dgvCaso.DataSource = null;
            dgvCaso.DataSource = consultas.VerCasosIDJefeDesarrollo(logueado);
        }

        private void dgvSolicitud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSolicitud.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                estado = int.Parse(dgvSolicitud.Rows[e.RowIndex].Cells["id_estado"].FormattedValue.ToString());


                if (estado != 1)
                {
                    MessageBox.Show("Esta solicitud ya ha sido aceptada o rechazada, favor seleccionar otra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Puede proceder a ingresar los datos para la asignación del caso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDAceptar.Text = dgvSolicitud.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    departamento = dgvSolicitud.Rows[e.RowIndex].Cells["Departamento"].FormattedValue.ToString();
                    fechasoli = dgvSolicitud.Rows[e.RowIndex].Cells["Fecha Solicitud"].FormattedValue.ToString();

                    dgvSolicitud.CurrentRow.Selected = true;
                    txtDescripcion.ReadOnly = false;
                    btnAñadir.Enabled = true;
                    btnLimpiar.Enabled = true;
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha indicada es menor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || txtDescripcion.Text.Equals("Descripción"))
            {
                MessageBox.Show("Ingrese una descripción para complementar la información del caso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            consultas.insertarCaso(GenerarCodigo(), Convert.ToInt32(txtIDAceptar.Text), txtDescripcion.Text, Convert.ToDateTime(dateTimePicker1.Value.ToString()), logueado, Convert.ToInt32(cmboTester.SelectedValue), Convert.ToInt32(cmboProgramador.SelectedValue));
            consultas.ActualizarEstadoSolicitud(Convert.ToInt32(txtIDAceptar.Text), 2, "En Desarrollo");
            VerCasos();
            verSolicitudes();
            limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnDepartamento.Height;
            pnlOnButtonPosition.Top = btnDepartamento.Top;
            panel2.Visible = true;
            panelRechazada.Visible = false;
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.ReadOnly != true)
            {
                if (txtDescripcion.Text == "Descripción")
                {
                    txtDescripcion.Clear();
                }
            }
        }

        private void txtArgumento_Click(object sender, EventArgs e)
        {
            txtArgumento.Clear();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnRechazarSolicitud.Height;
            pnlOnButtonPosition.Top = btnRechazarSolicitud.Top;
            panelRechazada.Visible = true;
            panel2.Visible = false;
        }

        private void dgvSolicitudes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int estado2;
            if (dgvSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSolicitudes.CurrentRow.Selected = true;
                estado2 = int.Parse(dgvSolicitudes.Rows[e.RowIndex].Cells["id_estado"].FormattedValue.ToString());

                if (estado2 != 1)
                {
                    MessageBox.Show("Esta solicitud ya ha sido aceptada o rechazada, favor seleccionar otra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Puede proceder a denegar el caso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdRechazar.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txtDescripcionRechazar.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["Descripción"].FormattedValue.ToString();
                    txtFechaRechazar.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["Fecha Solicitud"].FormattedValue.ToString();
                }
            }
            btnRechazar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdRechazar.Text);
            errorProvider1.Clear();
            bool state = true;

            if (!validar.validar_texto(txtArgumento.Text) || txtArgumento.Text == "Observaciones")
            {
                state = false;
                errorProvider1.SetError(txtArgumento, "Digite las observaciones, por favor.");

            }
            else
            {
                state = true;
            }
            if (state)
            {

                consultas.ActualizarEstadoSolicitud(id, 3, txtArgumento.Text);
                verSolicitudes();
                MessageBox.Show("Datos Actualizados Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            creditos creadores = new creditos();
            creadores.Show();
        }
    }
}
