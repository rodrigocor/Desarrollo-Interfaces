using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPaqueteria
{
    public partial class Form1 : Form
    {
        private double total;
        public Form1()
        {
            InitializeComponent();
            var tt1 = new ToolTip();
            tt1.SetToolTip(calcular, "Haga click para calcular");
            //comboBoxEnvio;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            resultado.Text = itemSeleccionado().ToString() + " €";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private double itemSeleccionado()
        {
            if (comboBoxEnvio.SelectedIndex==0)
            {
                total = total + 0.99;

            }

            if (comboBoxEnvio.SelectedIndex == 1)
            {
                total = total + 1.99;

            }

            if (comboBoxEnvio.SelectedIndex == 2)
            {
                total = total + 4.99;

            }

            if (notificaciones.GetItemChecked(1) == true)
            {

                total = total + 0.63;
            }

            if (notificaciones.GetItemChecked(2) == true)
            {
                total = total + 1.68;
            }

            return total;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
