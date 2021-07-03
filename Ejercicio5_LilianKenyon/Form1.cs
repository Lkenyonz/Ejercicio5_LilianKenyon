using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_LilianKenyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutarbutton1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            x = Convert.ToInt32(numfilatextBox1.Text);
            y= Convert.ToInt32(numcolumnatextBox2.Text);

            //Matriz

            int[,] Matrizx = new int[x, y];

            Random Numero  = new Random();

            for (int fila = 0; fila < x; fila++) 

            {
                for (int columna = 0; columna < y; columna++)

                {
                    Matrizx[fila, columna] = Numero.Next(1, 100);
                }
            }
            
                for (int fila = 0; fila < x; fila++)

            {
                for (int columna = 0; columna < y; columna++)
                {
                    MessageBox.Show("La matriz es: " + fila + "," + columna + " = " + Matrizx[fila, columna].ToString());
                }

            }

        }

        private void Limpiarbutton2_Click(object sender, EventArgs e)
        {
            numfilatextBox1.Clear();
            numcolumnatextBox2.Clear();
            numfilatextBox1.Focus();
        }
    }
}
