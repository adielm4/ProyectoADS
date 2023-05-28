using ProyectoADS.Properties;
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
    public partial class Login : Form
    {
        CRUD consultas = new CRUD();
        Validaciones validar = new Validaciones();
        public Login()
        {
            InitializeComponent();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Clear();
            }
            panel1.BackColor = Color.FromArgb(78, 104, 206);
            textBox1.ForeColor = Color.FromArgb(78, 104, 206);

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Clear();
            }
            panel2.BackColor = Color.FromArgb(78, 104, 206);
            textBox2.ForeColor = Color.FromArgb(78, 104, 206);
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
            textBox2.PasswordChar = '*';
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Movimiento.ReleaseCapture();
                Movimiento.SendMessage(Handle, Movimiento.WM_NCLBUTTONDOWN, Movimiento.HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();//Limpiar ErrorProvider
            bool state = true;

            if (!validar.validar_usuario(textBox1.Text))
            {
                state = false;
                errorProvider1.SetError(textBox1, "Debe ingresar un usuario apropiado. Ejemplo: Eduard13");
            }
            if (!validar.validar_password(textBox2.Text))
            {
                state = false;
                errorProvider1.SetError(textBox2, "Debe ingresar una contraseña apropiada.");
            }

            if (state)
            {
                string tipo = consultas.autentificarse(textBox1.Text, textBox2.Text);
                int idLogeado = consultas.idUsuarioLogeado(textBox1.Text, textBox2.Text);
                switch (tipo)
                {
                    case "1":
                        this.Dispose();
                        Administrador admin = new Administrador();
                        admin.ShowDialog();
                        break;
                            case "2":
                                this.Dispose();
                                JefeAreaFuncional JAF = new JefeAreaFuncional(idLogeado);
                                JAF.ShowDialog();
                                break;
                    //        case "3":
                    //            this.Dispose();
                    //            JefeDesarrollo JD = new JefeDesarrollo(idLogeado);
                    //            JD.ShowDialog();
                    //            break;
                    //        case "4":
                    //            this.Dispose();
                    //            tester frmTester = new tester(idLogeado);
                    //            frmTester.ShowDialog();
                    //            break;
                    //        case "5":
                    //            this.Dispose();
                    //            Programador coder = new Programador(idLogeado);
                    //            coder.ShowDialog();
                    //            break;
                    default:
                        label1.Text = "Usuario no válido";
                        break;
                }
            }
            }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Resources.ojo;
            textBox2.PasswordChar = default;

        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Resources.ojo2;
            textBox2.PasswordChar = '*';
        }


    }
}

