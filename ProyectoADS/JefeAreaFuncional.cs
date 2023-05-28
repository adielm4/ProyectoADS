using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class JefeAreaFuncional : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validar = new Validaciones();
        CRUD consultas = new CRUD();
        DateTime hoy = DateTime.Today;
        int logueado = 0;
        int estado = 0;
        public JefeAreaFuncional(int idUsuarioLogueado)
        {
            InitializeComponent();
            logueado = idUsuarioLogueado;
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción")
            {
                txtDescripcion.Clear();
            }
        }

        public void verJefesDesarrollo()
        {
            cboJefeDesarrollo.DisplayMember = "nombre";
            cboJefeDesarrollo.ValueMember = "id";
            cboJefeDesarrollo.DataSource = consultas.verJefesDesarrollo();
        }

        private void JefeAreaFuncional_Load(object sender, EventArgs e)
        {
            verJefesDesarrollo();
            verSolicitudes();
        }

        private void btnCrearSolicitud_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnCrearSolicitud.Height;
            pnlOnButtonPosition.Top = btnCrearSolicitud.Top;
            panel2.Visible = true;
            panelVerSolicitudes.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnVerSolicitudes_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnVerSolicitudes.Height;
            pnlOnButtonPosition.Top = btnVerSolicitudes.Top;
            panelVerSolicitudes.Visible = true;
            panel2.Visible = false;
        }

        public void verSolicitudes()
        {
            dgvSolicitudes.DataSource = null;
            dgvSolicitudes.DataSource = consultas.verSolicitudesPorIdUsuario(logueado, estado);
            dgvSolicitudes.Columns["id_estado"].Visible = false;
        }

        private void btnEspera_Click(object sender, EventArgs e)
        {
            estado = 1;
            verSolicitudes();
        }

        private void btnAprobados_Click(object sender, EventArgs e)
        {
            estado = 2;
            verSolicitudes();
        }

        private void btnRechazadas_Click(object sender, EventArgs e)
        {
            estado = 3;
            verSolicitudes();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            estado = 0;
            verSolicitudes();
        }

        private void dgvSolicitudes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSolicitudes.CurrentRow.Selected = true;
                int estado = int.Parse(dgvSolicitudes.Rows[e.RowIndex].Cells["id_estado"].FormattedValue.ToString());

                if(estado == 1)
                {
                    txtID.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txtDesc.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["Descripción"].FormattedValue.ToString();
                    txtFecha.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["Fecha de Creación"].FormattedValue.ToString();
                    txtJefeDesarrollo.Text = dgvSolicitudes.Rows[e.RowIndex].Cells["Departamento"].FormattedValue.ToString();
                    txtDesc.ReadOnly = false;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Solo puede modificar una solicitud que está en espera de respuesta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            txtID.Text = "ID";
            txtDesc.Text = "Descripción";
            txtFecha.Text = dtpFechaEntrega.Value.ToString("dd/MM/yyyy");
            txtJefeDesarrollo.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool state = true;
            int id = int.Parse(txtID.Text);

            if (!validar.validar_texto(txtDesc.Text) || txtDesc.Text == "Descripción")
            {
                state = false;
                errorProvider1.SetError(txtDesc, "Ingrese una descripción para el requerimiento.");

            }
            else
            {
                state = true;
            }
            if (state)
            {
                
                consultas.actualizarSolicitud(id, txtDesc.Text, dtpFechaEntrega.Value);
                verSolicitudes();
                MessageBox.Show("Datos actualizados Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool state = true;
            string fechaCorta = dtpFechaEntrega.Value.ToString("dd/MM/yyyy");

            if (!validar.validar_texto(txtDescripcion.Text) || txtDescripcion.Text == "Descripción")
            {
                state = false;
                errorProvider1.SetError(txtDescripcion, "Ingrese una descripción para el requerimiento.");

            }
            else
            {
                state = true;
            }
            if (state)
            {
                consultas.insertarSolicitud(txtDescripcion.Text, dtpFechaEntrega.Value, int.Parse(cboJefeDesarrollo.SelectedValue.ToString()), logueado);
                txtDescripcion.Text = "Descripción";
                verSolicitudes();
                MessageBox.Show("Solicitud creada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "Descripción";
        }

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            creditos creadores = new creditos();
            creadores.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

