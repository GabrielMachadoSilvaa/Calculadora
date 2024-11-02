using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_C_
{
    public partial class Base : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private string operador = "";
        private bool operadorSelecionado = false;

        public Base()
        {
            InitializeComponent();
            Visor_1.Text = "0";
        }

        private void Base_Load(object sender, EventArgs e)
        {
            Visor_1.Text = "0";
        }

        private void Visor_1_Click(object sender, EventArgs e)
        {
        }

        private void C_Click(object sender, EventArgs e)
        {
            Visor_1.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operador = "";
            operadorSelecionado = false;
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "0";
            else
                Visor_1.Text += "0";
            operadorSelecionado = false;
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "1";
            else
                Visor_1.Text += "1";
            operadorSelecionado = false;
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "2";
            else
                Visor_1.Text += "2";
            operadorSelecionado = false;
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "3";
            else
                Visor_1.Text += "3";
            operadorSelecionado = false;
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "4";
            else
                Visor_1.Text += "4";
            operadorSelecionado = false;
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "5";
            else
                Visor_1.Text += "5";
            operadorSelecionado = false;
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "6";
            else
                Visor_1.Text += "6";
            operadorSelecionado = false;
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "7";
            else
                Visor_1.Text += "7";
            operadorSelecionado = false;
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "8";
            else
                Visor_1.Text += "8";
            operadorSelecionado = false;
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            if (Visor_1.Text == "0" || operadorSelecionado)
                Visor_1.Text = "9";
            else
                Visor_1.Text += "9";
            operadorSelecionado = false;
        }

        private void Ponto_Click(object sender, EventArgs e)
        {
            if (!Visor_1.Text.Contains(","))
                Visor_1.Text += ",";
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            DefinirOperador("+");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            DefinirOperador("-");
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            DefinirOperador("*");
        }

        private void Div_Click(object sender, EventArgs e)
        {
            DefinirOperador("/");
        }

        private void Igual__Click(object sender, EventArgs e)
        {
            if (double.TryParse(Visor_1.Text, out valor2))
            {
                Calcular();
                if (operador != "")
                {
                    Visor_1.Text = valor1.ToString();
                }
                operador = "";
                operadorSelecionado = true;
            }
        }

        private void DefinirOperador(string op)
        {
            if (double.TryParse(Visor_1.Text, out valor2))
            {
                if (operador != "")
                {
                    Calcular();
                }
                valor1 = valor2;
                operador = op;
                Visor_1.Text += " " + operador + " ";
                operadorSelecionado = true;
            }
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    valor1 += valor2;
                    break;
                case "-":
                    valor1 -= valor2;
                    break;
                case "*":
                    valor1 *= valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        valor1 /= valor2;
                    }
                    else
                    {
                        Visor_1.Text = "Divisão por zero não é permitida.";
                        valor1 = 0;
                        return;
                    }
                    break;
            }
        }
    }
}
