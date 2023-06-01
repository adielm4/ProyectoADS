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
    public partial class tester : Form
    {

        Conexion conexion = new Conexion();
        Validaciones validar = new Validaciones();
        CRUD consultas = new CRUD();
        DateTime hoy = DateTime.Now;
        int logueado = 0;
        

        public tester(int idUsuarioLogueado)
        {
            InitializeComponent();
            logueado = idUsuarioLogueado;
            dtpFechaProduccion.MinDate = DateTime.Now.AddDays(1);
        }

        public void VerCasos()
        {
            dgvCasos.DataSource = null;
            dgvCasos.DataSource = consultas.VerCasosTester(logueado);
        }

        private void tester_Load(object sender, EventArgs e)
        {
            VerCasos();
        }

        private void dgvCasos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCasos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCasos.CurrentRow.Selected = true;
                float porcentajeAvance = float.Parse(dgvCasos.Rows[e.RowIndex].Cells["Avance"].FormattedValue.ToString().Replace('%', ' '));

                if(porcentajeAvance == 100)
                {
                    string idCaso = dgvCasos.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    if(consultas.TomandoEstadoSolicitud(idCaso) == 5)
                    {
                        txtID.Text = idCaso;
                        txtDesc.Text = dgvCasos.Rows[e.RowIndex].Cells["descripcion"].FormattedValue.ToString();
                        txtFecha.Text = dgvCasos.Rows[e.RowIndex].Cells["Fecha Limite"].FormattedValue.ToString();
                        txtAvance.Text = porcentajeAvance.ToString();
                        btnAprobar.Enabled = true;
                        btnHacerObservaciones.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este caso ya ha sido finalizado o devuelto con observaciones, seleccione otro por favor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para aprobar o rechazar un caso su porcentaje de avance debe ser del 100%.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void btnHacerObservaciones_Click(object sender, EventArgs e)
        {
            gpObservaciones.Visible = true;
            gpProduccion.Visible = false;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            gpProduccion.Visible = true;
            gpObservaciones.Visible = false;
        }
        private void btnObservaciones_click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool state = true;
            string idCaso = txtID.Text;

            if (!validar.validar_texto(txtObservaciones.Text) || txtObservaciones.Text == "Escribir observaciones puntuales")
            {
                state = false;
                errorProvider1.SetError(txtObservaciones, "Digite las observaciones.");
            }
            else if(numAvance.Value == 100)
            {
                state = false;
                MessageBox.Show("El porcentaje de avance debe indicarse como menor a 100%, ya que se realizarán correciones en el requerimiento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                state = true;
            }
            if (state)
            {
                consultas.ModificarEstadoSolicitud(7, idCaso);
                consultas.ActualizarObservaciones(idCaso, txtObservaciones.Text);
                consultas.ActualizarFechaLimiteCaso(idCaso);
                consultas.ModificarPorcentajeCaso(numAvance.Value, txtID.Text);
                VerCasos();
                btnAprobar.Enabled = false;
                btnHacerObservaciones.Enabled = false;
                txtObservaciones.Text = "Escribir observaciones puntuales";
                gpObservaciones.Visible = false;
                MessageBox.Show("El caso ha sido devuelto con observaciones. Datos Actualizados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtObservaciones_Click(object sender, EventArgs e)
        {
            txtObservaciones.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnFechaProduccion_Click(object sender, EventArgs e)
        {
            consultas.ModificarEstadoSolicitud(8, txtID.Text);
            consultas.AprobarCaso(txtID.Text, dtpFechaProduccion.Value);
            VerCasos();
            btnAprobar.Enabled = false;
            btnHacerObservaciones.Enabled = false;
            gpProduccion.Visible = false;
            MessageBox.Show("El caso ha sido aprobado y finalizado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            creditos creadores = new creditos();
            creadores.Show();
        }

        private void numAvance_ValueChanged(object sender, EventArgs e)
        {
            if (numAvance.Value < 100)
            {
                pbAvance.Value = int.Parse(numAvance.Value.ToString());
            }
            else
            {
                numAvance.Value = 99;
                MessageBox.Show("El porcentaje de avance debe indicarse como menor a 100%, ya que se realizarán correciones en el requerimiento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
