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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioContra.usuario = textUsuario.Text;
            UsuarioContra.contraseña = textContraseña.Text;
            string conUs = confirmUsuario.Text;
            string conCon = confirmContraseña.Text;
            

            Form1 crear = new Form1();
            crear.Close();

            int elemtos = UsuarioContra.usuario.Count();

            for(int i=0; i< textNombre.TextLength; i++)
            {
                if(!(char.IsLetter(textNombre.Text[i])))
                {
                    MessageBox.Show("Solo se permiten letras en nombre");
                    return;
                }
            }
            for (int x = 0; x< textapellidos.TextLength; x++)
            {
                if (!(char.IsLetter(textapellidos.Text[x])))
                {
                    MessageBox.Show("Solo se permiten letras apellidos");
                    return;
                }
            }

            if (UsuarioContra.usuario.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa el usuario");
                }
            }
            else if (elemtos > 3)
            {
                MessageBox.Show("El usuario no puede tener mas de tres elementos");
            }
            else if (UsuarioContra.contraseña.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa la contraseña");
                }
            }
            else if (conUs.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Confirma el Usuario");
                }
            }
            else if (conCon.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Confirma la Contraseña");
                }
            }
            else if (conCon.Equals(UsuarioContra.contraseña) == false)
            {
                MessageBox.Show("La contraseña no es la misma");
            }
            else if (conUs.Equals(UsuarioContra.usuario) == false)
            {
                MessageBox.Show("El usuario no es el mismo");
            }
            else if (textNombre.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu nombre");
                }
            }
            else if (textapellidos.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tus apellidos");
                }
            }
            else if (textGmail.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu Gmail");
                }
            }
            else
            {
                if ((conUs.Equals(UsuarioContra.usuario))&& (conCon.Equals(UsuarioContra.contraseña))){
                    Form1 principal = new Form1();
                    principal.Show();
                    Hide();
                }
            }
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void textGmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
