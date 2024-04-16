using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum operacoes
        {
            soma, multiplicacao, divisao, subtracao, nenhuma
        }
        static operacoes ultimaOperacao = operacoes.nenhuma;
        private void FazerCalculo(operacoes ultimaOperacao)
        {
            List<double> ListaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case operacoes.soma:
                    ListaDeNumeros = Display.Text.Split('+').Select(double.Parse).ToList();
                    Display.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case operacoes.subtracao:
                    ListaDeNumeros = Display.Text.Split('-').Select(double.Parse).ToList();
                    Display.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();

                    break;
                case operacoes.divisao:
                    ListaDeNumeros = Display.Text.Split('/').Select(double.Parse).ToList();
                    Display.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();

                    break;
                case operacoes.nenhuma:
                    break;
                case operacoes.multiplicacao:
                    ListaDeNumeros = Display.Text.Split('*').Select(double.Parse).ToList();
                    Display.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();

                    break;
                default:
                    break;
            }
        }

        private void button1_Del(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
        }

        private void numeros(object sender, EventArgs e)
        {
            Display.Text += (sender as Button).Text;

        }

        private void button2_Equal(object sender, EventArgs e)
        {
            if (ultimaOperacao != operacoes.nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = operacoes.nenhuma;
        }

        private void button17_Soma(object sender, EventArgs e)
        {
            if (ultimaOperacao == operacoes.nenhuma)
            {
                ultimaOperacao = operacoes.soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            Display.Text += (sender as Button).Text;
        }

        private void button15_Menos(object sender, EventArgs e)
        {
            if (ultimaOperacao == operacoes.nenhuma)
            {
                ultimaOperacao = operacoes.subtracao;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            Display.Text += (sender as Button).Text;
        }

        private void button1_Divisao(object sender, EventArgs e)
        {
            if (ultimaOperacao == operacoes.nenhuma)
            {
                ultimaOperacao = operacoes.divisao;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            Display.Text += (sender as Button).Text;
        }

        private void button12_Multip(object sender, EventArgs e)
        {
            if (ultimaOperacao == operacoes.nenhuma)
            {
                ultimaOperacao = operacoes.multiplicacao;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            Display.Text += (sender as Button).Text;
        }

        private void button11_CE(object sender, EventArgs e)
        {
            Display.Clear();
            ultimaOperacao = operacoes.nenhuma;
        }

        private void button14_Porcent(object sender, EventArgs e)
        {
            if (ultimaOperacao != operacoes.nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = operacoes.nenhuma;
        }
    }
}
