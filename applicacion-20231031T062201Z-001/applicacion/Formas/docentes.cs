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
    public partial class docentes : Form
    {
        public docentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int control = int.Parse(textBox3.Text);

                for (int i = 0; i < textBox3.TextLength; i++)
                {
                    if (!(char.IsNumber(textBox3.Text[i])))
                    {
                        MessageBox.Show("Solo se permiten numeros ");
                        return;
                    }
                }

                if (textBox1.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa el Nombre");
                    }
                }
                else if (textBox2.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa la RAM");
                    }
                }
                else if (textBox3.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa el numero de serie");
                    }
                }
                else if (comboBox1.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Selecciona tu marca");
                    }
                }
                else if (comboBox2.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Selecciona un procesadror");
                    }
                }
                else if (comboBox3.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Selecciona un dispositivo");
                    }
                }
                else if (control < 0)
                {

                }
                else
                {
                    DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    renglon.Cells[0].Value = textBox1.Text;
                    renglon.Cells[1].Value = textBox2.Text;
                    renglon.Cells[2].Value = textBox3.Text;
                    renglon.Cells[3].Value = comboBox1.Text;
                    renglon.Cells[4].Value = comboBox2.Text;
                    renglon.Cells[5].Value = comboBox3.Text;

                    dataGridView1.Rows.Add(renglon);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if (!(dataGridView1.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Modelo"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["RAM"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["No. Serie"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells["Procesador"].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells["Dispositivo"].Value.ToString();
            }
        }
    }
}
