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
 
    public partial class AgregarEstudiante : MetroForm
    {
        public Estudiante estudiante;
        char sexo;

        public AgregarEstudiante()
        {
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
                idField.MaxLength = 9; em.MaxLength = 30;


                int v = estudiante.AgregarEstudiante(idField.Text, em.Text, nom.Text, ap1.Text, ap2.Text, sexo,
                 fecha.Value.ToString("yyyy-MM-dd"), dir.Text, tel.Text, carnebox.Text, estad.Text);
                if (v == 0)
                {
                    bool agregado = estudiante.AgregarUsuario(username.Text, contra.Text, idField.Text);
                    if (agregado)
                    {
                        idField.Clear(); em.Clear(); nom.Clear(); ap1.Clear(); ap2.Clear(); dir.Clear();
                        tel.Clear(); carnebox.Clear(); estad.Clear();
                        username.Clear(); contra.Clear();
                        MessageBox.Show("Agregado correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe elusuario ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username.Clear(); contra.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un estudiante asociado a este numero de cedula en el sistema", "Resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
