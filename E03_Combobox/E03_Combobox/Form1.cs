using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E03_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_convertir_Click(object sender, EventArgs e)
        {
            obtenDatos();
            
        }

        /*******************METODOS PROPIOS*******************/
        void obtenDatos()
        {
            double grados, resultado;
            string op1, op2;

            grados = Convert.ToDouble(tb_grados.Text);
            op1 = cb_grados.Text;//tipo de grados ingresados
            op2 = cb_grados2.Text;//tipo de grados a convertir

            convertirGrados(grados, op1, op2);
        }

        void convertirGrados(Double gr, string opc1, string opc2)
        {
            Double resultado = 0;

            switch(opc1)//menu de grados ingresados
            {
                case "Celsius":
                    if (opc2 == "Kelvin")
                    {
                        resultado = gr + 273.15;
                    }
                    else if (opc2 == "Fahrenheit")
                    {
                        resultado = (gr * 1.8) + 32;
                    }
                    else
                    {
                        resultado = gr;
                    }

                    break;

                case "Fahrenheit":
                    if (opc2 == "Kelvin")
                    {
                        resultado = (gr + 469.67) * (5 / 9);
                    }
                    else if (opc2 == "Celsius")
                    {
                        resultado = (gr - 32)/1.8;
                    }
                    else
                    {
                        resultado = gr;
                    }

                    break;

                case "Kelvin":
                    if (opc2 == "Celsius")
                    {
                        resultado = gr - 273.15;
                    }
                    else if (opc2 == "Fahrenheit")
                    {
                        resultado = (gr - 273.15) * 1.8 + 32;
                    }
                    else
                    {
                        resultado = gr;
                    }

                    break;
            }
            tb_grados2.Text = resultado.ToString();

        }

        /*******************FIN METODOS PROPIOS***************/
    }
}
