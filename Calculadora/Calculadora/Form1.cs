using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class form : Form
    {

        public string n1 = "0";
        public string n2 = "0";
        public string n3 = "0";
        public string operador;

        public form()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
           if(operador == null) 
           {
                if (n1 == "0")
                {
                    n1 = "0";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "0";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "0";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "0";
                    resultLabel.Text = n2;
                }
            }
        }

        private void um_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "1";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "1";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "1";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "1";
                    resultLabel.Text = n2;
                }
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "2";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "2";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "2";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "2";
                    resultLabel.Text = n2;
                }
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "3";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "3";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "3";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "3";
                    resultLabel.Text = n2;
                }
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "4";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "4";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "4";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "4";
                    resultLabel.Text = n2;
                }
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "5";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "5";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "5";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "5";
                    resultLabel.Text = n2;
                }
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "6";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "6";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "6";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "6";
                    resultLabel.Text = n2;
                }
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "7";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "7";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "7";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "7";
                    resultLabel.Text = n2;
                }
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "8";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "8";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2= "8";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "8";
                    resultLabel.Text = n2;
                }
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "9";
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 += "9";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "9";
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 += "9";
                    resultLabel.Text = n2;
                }
            }
        }
        private void virgula_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1 == "0")
                {
                    n1 = "0,";
                    resultLabel.Text = n1;
                }
                else
                {
                    if (n1.Contains(","))
                    {
                        n1 += "0";
                        resultLabel.Text = n1;
                    }
                    else
                    {
                        n1 += ",";
                        resultLabel.Text = n1;
                    }
                }
            }
            else
            {
                if (n2 == "0")
                {
                    n2 = "0,";
                    resultLabel.Text = n2;
                }
                else
                {
                    if (n2.Contains(","))
                    {
                        n2 += "0";
                        resultLabel.Text = n2;
                    }
                    else
                    {
                        n2 += ",";
                        resultLabel.Text = n2;
                    }
                }
            }
        }

        private void limparTudo_Click(object sender, EventArgs e)
        {
            if(operador == null)
            {
                n1 = "0";
            }
            else
            {
                n2 = "0";
            }
            resultLabel.Text = n1;
        }

        private void limparOp_Click(object sender, EventArgs e)
        {
            n1 = "0";
            n2 = "0";
            n3 = "0";
            operador = null;
            resultLabel.Text = n1;
            anterior.Text = "0";
        }

        private void mais_Click(object sender, EventArgs e)
        {

                if (operador == null)
                {
                    resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                    n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
                }

                if (operador == "+")
                {
                    resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                    n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
                }
                if (operador == "-")
                {
                    resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                    n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
                }
                if (operador == "/")
                {
                    resultLabel.Text = (float.Parse(n1) / float.Parse(n2)).ToString();
                    n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
                }
                if (operador == "x")
                {
                    resultLabel.Text = (float.Parse(n1) * float.Parse(n2)).ToString();
                    n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
                }
                if (operador == "%")
                {
                    n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                    resultLabel.Text = n1;
                }

            if (n3 == "0")
                {
                    n3 = n1 + " + ";
                    anterior.Text = n3;
                }
                else
                {
                    n3 = n3 + n2 + " + ";
                    anterior.Text = n3;
                }

            operador = "+";
            n2 = "0";
        }


        private void menos_Click(object sender, EventArgs e)
        {

            if (operador == null)
            {
                resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
            }

            if (operador == "+")
            {
                resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
            }
            if (operador == "-")
            {
                resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
            }
            if (operador == "/")
            {
                resultLabel.Text = (float.Parse(n1) / float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
            }
            if (operador == "x")
            {
                resultLabel.Text = (float.Parse(n1) * float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
            }
            if (operador == "%")
            {
                n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                resultLabel.Text = n1;
            }

            if (n3 == "0")
            {
                n3 = n1 + " - ";
                anterior.Text = n3;
            }
            else
            {
                n3 = n3 + n2 + " - ";
                anterior.Text = n3;
            }

            operador = "-";
            n2 = "0";
        }

        private void divide_Click(object sender, EventArgs e)
        {

            if (operador == null)
            {
                resultLabel.Text = n1;
            }

            if (operador == "+")
            {
                resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
            }
            if (operador == "-")
            {
                resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
            }
            if (operador == "/")
            {
                resultLabel.Text = (float.Parse(n1) / float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
            }
            if (operador == "x")
            {
                resultLabel.Text = (float.Parse(n1) * float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
            }
            if (operador == "%")
            {
                n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                resultLabel.Text = n1;
            }

            if (n3 == "0")
            {
                n3 = n1 + " / ";
                anterior.Text = n3;
            }
            else
            {
                n3 = n3 + n2 + " / ";
                anterior.Text = n3;
            }

            operador = "/";
            n2 = "0";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                resultLabel.Text = n1;
            }

            if (operador == "+")
            {
                resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
            }
            if (operador == "-")
            {
                resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
            }
            if (operador == "/")
            {
                resultLabel.Text = (float.Parse(n1) / float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
            }
            if (operador == "x")
            {
                resultLabel.Text = (float.Parse(n1) * float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
            }
            if (operador == "%")
            {
                n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                resultLabel.Text = n1;
            }

            if (n3 == "0")
            {
                n3 = n1 + " x ";
                anterior.Text = n3;
            }
            else
            {
                n3 = n3 + n2 + " x ";
                anterior.Text = n3;
            }

            operador = "x";
            n2 = "0";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                resultLabel.Text = n1;
            }

            if (operador == "+")
            {
                resultLabel.Text = (float.Parse(n1) + float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
            }
            if (operador == "-")
            {
                resultLabel.Text = (float.Parse(n1) - float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
            }
            if (operador == "/")
            {
                resultLabel.Text = (float.Parse(n1) / float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
            }
            if (operador == "x")
            {
                resultLabel.Text = (float.Parse(n1) * float.Parse(n2)).ToString();
                n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
            }
            if (operador == "%")
            {
                n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                resultLabel.Text = n1;
            }

            if (n3 == "0")
            {
                n3 = n1 + "% ";
                anterior.Text = n3;
            }
            else
            {
                n3 = n3 + n2 + "% ";
                anterior.Text = n3;
            }

            operador = "%";
            n2 = "0";
    }

        private void igualar_Click(object sender, EventArgs e)
        {
            if(operador != null)
            {

                if(operador == "+")
                {
                    n1 = (float.Parse(n1) + float.Parse(n2)).ToString();
                    resultLabel.Text = n1;
                }
                if (operador == "-")
                {
                    n1 = (float.Parse(n1) - float.Parse(n2)).ToString();
                    resultLabel.Text = n1;
                }
                if (operador == "/")
                {
                    n1 = (float.Parse(n1) / float.Parse(n2)).ToString();
                    resultLabel.Text = n1;
                }
                if (operador == "x")
                {
                    n1 = (float.Parse(n1) * float.Parse(n2)).ToString();
                    resultLabel.Text = n1;
                }
                if (operador == "%")
                {
                    n1 = ((float.Parse(n1) / 100) * (float.Parse(n2))).ToString();
                    resultLabel.Text = n1;
                }

                n2 = "0";
                n3 = "0";
                anterior.Text = "0";
                operador = null;

            }
            else
            {
                resultLabel.Text = "0";
                n1 = "0";
                n2 = "0";
                n3 = "0";
                anterior.Text = "0";
                operador = null;
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                if (n1.Length > 0)
                {
                    n1 = n1.Remove(n1.Length - 1);
                    resultLabel.Text = n1;
                }
                else
                {
                    n1 = "0";
                    resultLabel.Text = n1;
                }
            }
            else
            {
                if (n2.Length > 0)
                {
                    n2 = n2.Remove(n2.Length - 1);
                    resultLabel.Text = n2;
                }
                else
                {
                    n2 = "0";
                    resultLabel.Text = n2;
                }
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
