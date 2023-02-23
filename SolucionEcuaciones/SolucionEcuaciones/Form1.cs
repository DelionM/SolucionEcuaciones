using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEcuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String extraer, numeros, letras = "", ecuacion;
        int x, num;
        double resultado;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

//----------------------------------------------------------------------------------

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // String numero = txtEcu.Text;
            // int digito = 0;
            // int letrass = 0;
            //// ObtenerChars();
            // for (int i = 0; i < numero.Length; i++)
            // {
            //     digito = Convert.ToInt32(numero[i]) - 48;
            //     letrass =(numero[i]);
            //     MessageBox.Show("número "+digito);
            //     MessageBox.Show("letra " + letrass);
            //     numero = string.Empty;
            //    // letrass = string.Empty;

            // }
            x = Convert.ToInt32(txtX.Text);
            numeros = "";
            letras = "";
            ecuacion = txtEcu.Text.Trim();
            for (int i = 0; i < ecuacion.Length; i++)
            {
                extraer = ecuacion.Substring(i, 1);
                switch (extraer)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":i
                    case "9":
                        numeros = numeros + extraer;
                        break;
                    default:
                        letras = letras + extraer;
                        break;
                }
                MessageBox.Show("número " + numeros);
                MessageBox.Show("letra " + letras);
                numeros = string.Empty;
                letras = string.Empty;
                //CONVERTIR A INT
                num = Convert.ToInt32(numeros);

                if (letras == "+")
                {
                    resultado = num + x;
                    MessageBox.Show("ressss " + resultado);
                }

                else if (letras == "-")
                {
                    resultado = num - x;
                    MessageBox.Show("ressss " + resultado);
                }

                else if (letras == "*")
                {
                    resultado = num * x;
                    MessageBox.Show("ressss " + resultado);
                }

                else if (letras == "/")
                {
                    resultado = num / x;
                    MessageBox.Show("ressss " + resultado);
                }
            }
        }
    }
}
