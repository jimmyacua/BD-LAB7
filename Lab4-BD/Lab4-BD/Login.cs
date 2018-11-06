using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Lab4_BD
{
    public partial class Login : MetroForm
    {
        Estudiante estudiante;
        public Login()
        {
            estudiante = new Estudiante();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (userbox.Text == null)
            {
                MessageBox.Show("Debe digitar un nombre de usuario válido", "Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passBox.Text == null)
            {
                MessageBox.Show("Debe digitar una contraseña válida", "Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                bool log = estudiante.LoginFuction(userbox.Text, passBox.Text);
                if (log) {
                    AgregarEstudiante agregar = new AgregarEstudiante();
                    agregar.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña inválido", "Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
