using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using applicacion.Formas;

namespace applicacion
{
    public partial class Form1 : Form
    {
        int contador = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta crear = new CrearCuenta();
            crear.Show();
            Hide();
        }



        private void ususario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario2 = textususario2.Text;
                string contraseña2 = textcontraseña2.Text;


                if ((usuario2.Equals(UsuarioContra.usuario)) && (contraseña2.Equals(UsuarioContra.contraseña)))
                {
                    Estudiantes est = new Estudiantes();
                    est.Show();
                    Hide();

                }
                else
                {
                    if (contador == 0)
                    {
                        MessageBox.Show("Tus intentos han terminado");
                        Application.Exit();
                    }
                    else if ((contraseña2.Equals(UsuarioContra.contraseña)) == false)
                    {
                        MessageBox.Show("La contraseña es Incorrecta");
                        contador = contador - 1;
                    }
                    else if ((usuario2.Equals(UsuarioContra.usuario)) == false)
                    {
                        MessageBox.Show("El usuario es Incorrecto");
                        contador = contador - 1;
                    }
                }
                
            }
            catch(Exception error)
            {
                string usuario2 = textususario2.Text;
                string contraseña2 = textcontraseña2.Text;
                if (((string.IsNullOrEmpty(usuario2)) == false) && ((string.IsNullOrEmpty(contraseña2))) == false)
                {
                    MessageBox.Show("No has Ingresado nada, ¿Ya te registraste?");
                }
                else if (usuario2.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa el usuario");
                    }
                }
                else if (contraseña2.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa la contraseña");
                    }
                }
            }
           
           
        }
    }
}
