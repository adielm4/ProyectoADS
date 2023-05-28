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
    public partial class Administrador : Form
    {
        CRUD consultas = new CRUD();
        Validaciones validar = new Validaciones();
        
        public Administrador()
        {
            InitializeComponent();
        }
        
        private void Administrador_Load(object sender, EventArgs e)
        {
            verRoles();
            verDepartamento();
            verUsuario();
        }
        public void verUsuario()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = consultas.verUsuario();
        }

        public void resetear()
        {
            txtIdDepartamento.Text = "ID";
            txtID.Text= "ID";
            txtNombreDepartamento.Text= "Nombre";
            txtNombreUsuario.Text="Nombre";
            txtUsername.Text="Usuario";
            txtContraseña.Text="Contraseña";
            cmboDepa.SelectedIndex = 0;
            cmboRol.SelectedIndex = 0;
        }

        public void verDepartamento()
        {
            cmboDepa.DisplayMember = "Nombre departamento";
            cmboDepa.ValueMember = "ID";
            cmboDepa.DataSource = consultas.verDepartamento();
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = consultas.verDepartamento();
        }
        public void verRoles()
        {
            cmboRol.DisplayMember = "descripcion";
            cmboRol.ValueMember = "id";
            cmboRol.DataSource = consultas.verRoles();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnUsuario.Height;
            pnlOnButtonPosition.Top = btnUsuario.Top;
            panelDepartamentos.Visible = false;
            panelUsuarios.Visible = true;
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnDepartamento.Height;
            pnlOnButtonPosition.Top = btnDepartamento.Top;
            panelUsuarios.Visible = false;
            panelDepartamentos.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnDepartamento.Height;
            pnlOnButtonPosition.Top = btnDepartamento.Top;
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();//Limpiar ErrorProvider
            bool state = true;

            if (!validar.validar_texto2(txtNombreUsuario.Text))
            {
                state = false;
                errorProvider2.SetError(txtNombreUsuario, "Debe ingresar un nombre apropiado.");
            }
            if (!validar.validar_usuario(txtUsername.Text))
            {
                state = false;
                errorProvider2.SetError(txtUsername, "Debe ingresar un usuario apropiado. Debe contener solo letras y números.");
            }
            if (!validar.validar_password(txtContraseña.Text))
            {
                state = false;
                errorProvider2.SetError(txtContraseña, "Debe ingresar una contraseña apropiada.");
            }

            if (state)
            {
                consultas.insertarUsuario(Convert.ToInt32(cmboRol.SelectedValue), Convert.ToInt32(cmboDepa.SelectedValue), txtNombreUsuario.Text, txtUsername.Text, txtContraseña.Text);
                verUsuario();
                resetear();
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();//Limpiar ErrorProvider
            bool state = true;

            if (!validar.validar_texto2(txtNombreUsuario.Text))
            {
                state = false;
                errorProvider2.SetError(txtNombreUsuario, "Debe ingresar un nombre apropiado.");
            }
            if (!validar.validar_usuario(txtUsername.Text))
            {
                state = false;
                errorProvider2.SetError(txtUsername, "Debe ingresar un usuario apropiado. Debe contener solo letras y números.");
            }
            if (!validar.validar_password(txtContraseña.Text))
            {
                state = false;
                errorProvider2.SetError(txtContraseña, "Debe ingresar una contraseña apropiada.");
            }

            if (state)
            {
                consultas.updateUsuario(Convert.ToInt32(txtID.Text), Convert.ToInt32(cmboRol.SelectedValue), Convert.ToInt32(cmboDepa.SelectedValue), txtNombreUsuario.Text, txtUsername.Text, txtContraseña.Text);
                verUsuario();
                resetear();
                btnAñadirUsuario.Enabled = true;
                btnActualizarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                cmboRol.SelectedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idRol"].FormattedValue.ToString());
                cmboDepa.SelectedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDepartamento"].FormattedValue.ToString());
                txtNombreUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["usuario"].FormattedValue.ToString();
                txtContraseña.Text = dataGridView1.Rows[e.RowIndex].Cells["pass"].FormattedValue.ToString();

                btnActualizarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnAñadirUsuario.Enabled = false;
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                consultas.eliminarUsuario(Convert.ToInt32(txtID.Text));
                verUsuario();
                resetear();
                btnActualizarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al eliminar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            resetear();
            btnAñadirUsuario.Enabled = true;
        }

        private void Administrador_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Movimiento.ReleaseCapture();
                Movimiento.SendMessage(Handle, Movimiento.WM_NCLBUTTONDOWN, Movimiento.HT_CAPTION, 0);
            }
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Nombre")
            {
                txtNombreUsuario.Clear();
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Usuario")
            {
                txtUsername.Clear();
            }
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            creditos creadores = new creditos();
            creadores.Show();
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();//Limpiar ErrorProvider
            bool state = true;

            if (!validar.validar_Depa(txtNombreDepartamento.Text))
            {
                state = false;
                errorProvider1.SetError(txtNombreDepartamento, "Debe de empezar con 'Departamento de' seguido por el área.");
            }

            if (state)
            {
                consultas.insertarDepartamento(txtNombreDepartamento.Text);
                txtNombreDepartamento.Clear();
                verDepartamento();
                resetear();
            }
        }

        private void btnLimpiarDepartamento_Click(object sender, EventArgs e)
        {
            resetear();
            btnAgregarDepartamento.Enabled = true;
            btnActualizarDepartamento.Enabled = false;
            btnEliminarDepartamento.Enabled = false;
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();//Limpiar ErrorProvider
            bool state = true;

            if (!validar.validar_texto2(txtNombreDepartamento.Text))
            {
                state = false;
                errorProvider1.SetError(txtNombreDepartamento, "Debe ingresar un nombre apropiado.");
            }

            if (state)
            {
                consultas.actualizarDepartamento(Convert.ToInt32(txtIdDepartamento.Text), txtNombreDepartamento.Text);
                verDepartamento();
                resetear();
            }

            btnActualizarDepartamento.Enabled = false;
            btnEliminarDepartamento.Enabled = false;
            btnAgregarDepartamento.Enabled = true;
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            consultas.eliminarDepartamento(Convert.ToInt32(txtIdDepartamento.Text));
            verDepartamento();
            resetear();
            btnActualizarDepartamento.Enabled = false;
            btnEliminarDepartamento.Enabled = false;
            btnAgregarDepartamento.Enabled = true;
        }

        private void dgvDepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartamentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDepartamentos.CurrentRow.Selected = true;
                txtIdDepartamento.Text = dgvDepartamentos.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtNombreDepartamento.Text = dgvDepartamentos.Rows[e.RowIndex].Cells["Nombre departamento"].FormattedValue.ToString();
            }
            btnAgregarDepartamento.Enabled = false;
            btnActualizarDepartamento.Enabled = true;
            btnEliminarDepartamento.Enabled = true;
        }

        private void txtNombreDepartamento_Click(object sender, EventArgs e)
        {
            if (txtNombreDepartamento.Text == "Nombre")
            {
                txtNombreDepartamento.Clear();
            }
        }
    }
}
