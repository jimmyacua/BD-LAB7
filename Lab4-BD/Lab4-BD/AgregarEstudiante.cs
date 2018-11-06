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
using Lab_Interfaces;

namespace Lab4_BD
{
 
    public partial class AgregarEstudiante : MetroForm
    {
        public Estudiante estudiante;
        char sexo;
        AccesoBaseDatos bd;

        public AgregarEstudiante()
        {
            bd = new AccesoBaseDatos();
            sexo = 'O';
            InitializeComponent();
            estudiante = new Estudiante();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            ListaEstudiante lista = new ListaEstudiante();
            lista.Show();
            Hide();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            EliminarEstudiante eliminar = new EliminarEstudiante();
            eliminar.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_2(object sender, EventArgs e)
        {

        }


        private void guardar_Click(object sender, EventArgs e)
        {
            if (!idField.Text.Contains(".") && !idField.Text.Contains(",") && !idField.Text.Contains("$")) //agregar más
            {
                idField.MaxLength = 9; em.MaxLength = 20; nom.MaxLength = 15; ap1.MaxLength = 15; ap2.MaxLength = 15;
                dir.MaxLength = 30; tel.MaxLength = 8; carnebox.MaxLength = 6; estad.MaxLength = 15;

                int v = estudiante.AgregarEstudiante(idField.Text, em.Text, nom.Text, ap1.Text, ap2.Text, sexo,
                        fecha.Value.ToString("yyyy-MM-dd"), dir.Text, tel.Text, carnebox.Text, estad.Text);
                bool agregado = estudiante.AgregarUsuario(username.Text, contra.Text, idField.Text);
                if (agregado && v == 0)
                {
                    idField.Clear(); em.Clear(); nom.Clear(); ap1.Clear(); ap2.Clear(); dir.Clear();
                    tel.Clear(); carnebox.Clear(); estad.Clear();
                    username.Clear(); contra.Clear();
                    MessageBox.Show("Agregado correctamente", "Agregar",
                      MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (!agregado)
                {
                    bd.EjecutarConsulta("DELETE FROM Estudiante Where Cedula = '" + idField.Text + "';");
                    MessageBox.Show("El usuario ya existe", "Agregar",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    bd.EjecutarConsulta("DELETE FROM Usuarios Where nombreUsuario = '" + username.Text + "';");
                    MessageBox.Show("Ya existe un estudiante asociado a este numero de cedula en el sistema", "Resultados",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else {
                MessageBox.Show("Cédula Inválida", "Agregar",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 'F';
        }

        private void masc_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 'M';
        }
    }
}
