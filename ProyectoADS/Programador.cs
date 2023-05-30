using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Proyecto
{
    public partial class Programador : Form
    {
        Conexion conexion = new Conexion();
        CRUD consultas = new CRUD();
        Validaciones validar = new Validaciones();

        int idUsuario = 0;
        public Programador(int idUsuarioLogueado)
        {
            InitializeComponent();
            idUsuario = idUsuarioLogueado;
            panelCaso.Show();
            leercasos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            creditos creadores = new creditos();
            creadores.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.ShowDialog();
        }

        private void leercasos()
        {
            IDcasos.ValueMember = "id";
            IDcasos.DisplayMember = "id";
            IDcasos.DataSource = consultas.verCasos(idUsuario);
            cbxbitacoraid.ValueMember = "id";
            cbxbitacoraid.DisplayMember = "id";
            cbxbitacoraid.DataSource = consultas.verCasos(idUsuario);
        }
        private void leerbitacoras()
        {
            dgvBitacoras.DataSource = null;
            dgvBitacoras.DataSource = consultas.verBitacoras(cbxbitacoraid.SelectedValue.ToString());
            string id = (cbxbitacoraid.SelectedValue.ToString());
            int estado = consultas.TomandoEstadoSolicitud(id);
            if (estado == 5)
            {
                label13.Show();
                lblEstadobitacora.Show();
                lblEstadobitacora.Text = "Caso ya finalizado";
                txtDescripcion.Hide();
                Enviar.Hide();
            }
            else if (estado == 6)
            {
                label13.Show();
                lblEstadobitacora.Show();
                lblEstadobitacora.Text = "Caso vencido";
                txtDescripcion.Hide();
                Enviar.Hide();
            }
            else
            {
                label13.Hide();
                lblEstadobitacora.Hide();
                txtDescripcion.Show();
                Enviar.Show();
            }
        }
        private void cargar_casos(string id)
        {
            SqlDataReader registro = consultas.CargarCasos(id);
            while (registro.Read())
            {
                numericUpDown1.Minimum = 0;
                label6.Text = registro["idSolicitud"].ToString();
                label4.Text = registro["descripcion"].ToString();
                numericUpDown1.Value = int.Parse(registro["porcentaje_avance"].ToString());
                numericUpDown1.Minimum = numericUpDown1.Value;
                progressBar1.Value = int.Parse(registro["porcentaje_avance"].ToString());
                label11.Text = registro["observaciones"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(registro["fecha_limite"].ToString());
            }
            conexion.desconectar();
            string fechaCorta = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            if (dateTimePicker1.Value.Date <= DateTime.Now.Date)
            {
                string x = "";
                int estado = 6;
                x = (IDcasos.SelectedValue.ToString());
                consultas.ModificarEstadoSolicitud(estado, x);
                label10.Show();
                lblEstado.Show();
                lblEstado.Text = "Vencido";
                actualizar.Enabled = false;
            }
            else if (numericUpDown1.Value == 100)
            {
                string x = "";
                int estado = 5;
                x = (IDcasos.SelectedValue.ToString());
                consultas.ModificarEstadoSolicitud(estado, x);
                label10.Show();
                lblEstado.Show();
                lblEstado.Text = "Esperando aprobación de área solicitante.";
            }
            else
            {
                label10.Hide();
                lblEstado.Hide();
                actualizar.Enabled = true;
            }
        }

        private void btncaso_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btncaso.Height;
            pnlOnButtonPosition.Top = btncaso.Top;
            panelCaso.Show();
            panelbitacora.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = numericUpDown1.Value;

            consultas.ModificarPorcentajeCaso(numericUpDown1.Value, IDcasos.SelectedValue.ToString());

            SqlDataReader registro = consultas.Registros(IDcasos.SelectedValue.ToString());

            while (registro.Read())
            {
                numericUpDown1.Value = int.Parse(registro["porcentaje_avance"].ToString());
                progressBar1.Value = int.Parse(registro["porcentaje_avance"].ToString());
            }
            conexion.desconectar();
            if (numericUpDown1.Value == 100)
            {
                string x = "";
                int estado = 5;
                x = (IDcasos.SelectedValue.ToString());
                consultas.ModificarEstadoSolicitud(estado, x);
                label10.Show();
                lblEstado.Show();
                lblEstado.Text = "Esperando aprobación de área solicitante";
            }
            else
            {
                label10.Hide();
                lblEstado.Hide();
            }

        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            leerbitacoras();
            pnlOnButtonPosition.Height = bitacora.Height;
            pnlOnButtonPosition.Top = bitacora.Top;
            panelbitacora.Show();
            panelCaso.Hide();
            groupBox3.Show();

        }

        private void Enviar_Click(object sender, EventArgs e)
        {

            string descripcion;
            descripcion = txtDescripcion.Text;
            if (validar.validar_texto(descripcion))
            {
                consultas.crearbitacora((cbxbitacoraid.SelectedValue.ToString()), descripcion);
                txtDescripcion.Text = descripcion;
                leerbitacoras();
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "Introduzca una descripción de la actividad realizada.");
            }
            txtDescripcion.Clear();
           
        }

        private void txbdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void IDcasos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDcasos.SelectedIndex != -1)
            {
                string id = IDcasos.SelectedValue.ToString();
                cargar_casos(id);

            }
        }

        private void txtDescripcion_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Text.Equals("Ingrese una descripción ..."))
            {
                txtDescripcion.Clear();
            }
        }
    }
}
