using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquinaRefrescos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monedas.Hide();
            pictureBoxRndija.Hide();
            botellaAmarilla.Hide();
            botellaAzul.Hide();
            botellaMorada.Hide();
            botellaRoja.Hide();
            botellaVerde.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void boton1(object sender, EventArgs e)
        {
            label2.Text = "1,15";
            label1.Text = "Escriba el dinero que quiere ingresar en el cuadro blanco, y haga click en la palanca";
        }
        private void boton2(object sender, EventArgs e)
        {
            label2.Text = "2";
            label1.Text = "Escriba el dinero que quiere ingresar en el cuadro blanco, y haga click en la palanca";
        }
        private void boton3(object sender, EventArgs e)
        {
            label2.Text = "0,50";
            label1.Text = "Escriba el dinero que quiere ingresar en el cuadro blanco, y haga click en la palanca";
        }
        private void boton4(object sender, EventArgs e)
        {
            label2.Text = "3";
            label1.Text = "Escriba el dinero que quiere ingresar en el cuadro blanco, y haga click en la palanca";
        }
        private void boton5(object sender, EventArgs e)
        {
            label2.Text = "1";
            label1.Text = "Escriba el dinero que quiere ingresar en el cuadro blanco, y haga click en la palanca";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcular(object sender, EventArgs e)
        {
            double precio=0;
            double dineroIntroducido=0;
            double res = 0;
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text="No ha introducido dinero, introduzca la cantidad que deseé";
            }

            if (!string.IsNullOrEmpty(label2.Text)){
                precio = double.Parse(label2.Text);
                dineroIntroducido = double.Parse(textBox1.Text);
                res = dineroIntroducido - precio;
                if (res  >= 0.0)
                {

                    if (label2.Text == "1,15")
                    {
                        botellaAmarilla.Show();
                        
                        pictureBoxRndija.Show();
                        botellaAmarilla.BringToFront();
                    }

                    if (label2.Text == "2")
                    {
                        botellaMorada.Show();
                        pictureBoxRndija.Show();
                        botellaMorada.BringToFront();
                    }

                    if (label2.Text == "0,50")
                    {
                        botellaVerde.Show();
                        pictureBoxRndija.Show();
                        botellaVerde.BringToFront();
                    }

                    if (label2.Text == "3")
                    {
                        botellaRoja.Show();
                        pictureBoxRndija.Show();
                        botellaRoja.BringToFront();
                    }

                    if (label2.Text == "1")
                    {
                        botellaAzul.Show();
                        pictureBoxRndija.Show();
                        botellaAzul.BringToFront();
                    }
                    if(res >= 0.0)
                    {
                        label1.Text = "Recoja su cambio abajo, clickando";
                        cambio.Text = res.ToString();
                        monedas.Show();

                    }
                    
                }
                else
                {
                    label1.Text = "Dinero insuficiente, Recoja su cambio abajo, clickando;";
     
                    cambio.Text = dineroIntroducido.ToString();
                    monedas.Show();
                }


            }
        }

        private void recogerCambio(object sender, EventArgs e)
        {
            label1.Text = "Introduzca el número del producto, actualmente solo 5 bebidas, 1 numero por columna";
            monedas.Hide();
            cambio.Text = "";
            label2.Text = "0";
            textBox1.Text = "";
             
            pictureBoxRndija.Hide();
            botellaAmarilla.Hide();
            botellaAzul.Hide();
            botellaMorada.Hide();
            botellaRoja.Hide();
            botellaVerde.Hide();
        }

        //private void 
    }
}
