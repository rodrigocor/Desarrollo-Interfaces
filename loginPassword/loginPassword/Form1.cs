using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPassword
{
    
    public partial class Form1 : Form
    {
        string loggin;
        string password;

 

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btInicioSesion.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iniciarSesion(object sender, EventArgs e)
        {

                if (tbLoggin.Text == loggin && tbPassword.Text == password)
                {
                    MessageBox.Show("SESION INICIADA,bienvenido", "Aplicacion Login");
                }

                else
                {
                    MessageBox.Show("Credenciales erróneas", "Aplicacion Login");
                    tbPassword.ResetText();
                    tbLoggin.ResetText();
                }
            


        }

        private void CrearCuenta(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLoggin.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Alguno de los campos no está relleno", "Aplicacion Login");
            }

            if (!string.IsNullOrEmpty(tbLoggin.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                loggin =tbLoggin.Text;
                password = tbPassword.Text;
            
                tbLoggin.Clear();
                tbPassword.Clear();

                btCrearCuenta.Hide();
                btInicioSesion.Show();

            }
            }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
