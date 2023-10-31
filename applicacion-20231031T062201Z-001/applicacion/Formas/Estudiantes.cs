using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicacion.Formas
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int control = int.Parse(TextBox3.Text);

                for (int i = 0; i <TextBox3.TextLength; i++)
                {
                    if (!(char.IsNumber(TextBox3.Text[i])))
                    {
                        MessageBox.Show("Solo se permiten ");
                        return;
                    }
                }

                if (TextBox1.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa un nombre");
                    }
                }
                else if (TextBox2.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa tus apellidos");
                    }
                }
                else if (TextBox3.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa el control");
                    }
                }
                else if (comboBox1.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Selecciona una carrera");
                    }
                }
                else if (comboBox2.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Selecciona un grupo");
                    }
                }
                else if (control < 0)
                {

                }
                else
                {
                    DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();
                    renglon.Cells[0].Value = TextBox1.Text;
                    renglon.Cells[1].Value = TextBox2.Text;
                    renglon.Cells[2].Value = TextBox3.Text;
                    renglon.Cells[3].Value = comboBox1.Text;
                    renglon.Cells[4].Value = comboBox2.Text;

                    dataEstudiante.Rows.Add(renglon);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if(!(dataEstudiante.CurrentRow is null))
            {
                if(MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un rengoln", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TextBox1.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                TextBox2.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                TextBox3.Text = dataEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Group"].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
