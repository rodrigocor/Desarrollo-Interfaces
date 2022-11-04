using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumasDe1aN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var tt1 = new ToolTip();
            tt1.SetToolTip(Iniciar, "Haga click para calcular");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            listBoxSumando.Items.Clear();
            int parcial = 0;
            for (int i=0;i< numericUpDown1.Value;i++)
            {
                
                if (checkBox1.Checked)
                {

                    listBoxSumando.Items.Add("sumando: " + (i + 1) + " Suma Parcial: " + ((i+1)+parcial));
                    parcial=i+1 + parcial;
                }
                else
                {
                    listBoxSumando.Items.Add("sumando: " + (i+1) );
                    parcial = i + 1 + parcial;
                }
                
            }

                listBoxSumando.Items.Add("La suma TOTAL es: " + parcial);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
