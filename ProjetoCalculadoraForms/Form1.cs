using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadoraForms
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperacao.Items.Add("Adição");
            cmbOperacao.Items.Add("Subtração");
            cmbOperacao.Items.Add("Multiplicação");
            cmbOperacao.Items.Add("Divisão");
            cmbOperacao.SelectedIndex = 0;
            // Estilizar os controles
            this.BackColor = Color.LightGray;
            cmbOperacao.BackColor = Color.White;
            txtNumero1.BackColor = Color.White;
            txtNumero2.BackColor = Color.White;
            btnCalcular.BackColor = Color.FromArgb(0, 123, 255);
            btnCalcular.ForeColor = Color.White;
            Resultado.ForeColor = Color.Black;
            Resultado.Font = new Font(Resultado.Font, FontStyle.Bold);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Ajustar o tamanho dos controles quando o formulário for redimensionado
            cmbOperacao.Width = 200;
            txtNumero1.Width = 200;
            txtNumero2.Width = 200;
            btnCalcular.Width = 200;
            Resultado.Width = 200;

            // Centralizar os controles na tela
            cmbOperacao.Left = (this.ClientSize.Width - cmbOperacao.Width) / 2;
            txtNumero1.Left = (this.ClientSize.Width - txtNumero1.Width) / 2;
            txtNumero2.Left = (this.ClientSize.Width - txtNumero2.Width) / 2;
            btnCalcular.Left = (this.ClientSize.Width - btnCalcular.Width) / 2;
            Resultado.Left = (this.ClientSize.Width - Resultado.Width) / 2;

            int marginTop = 20;
            cmbOperacao.Top = marginTop;
            txtNumero1.Top = cmbOperacao.Bottom + marginTop;
            txtNumero2.Top = txtNumero1.Bottom + marginTop;
            btnCalcular.Top = txtNumero2.Bottom + marginTop;
            Resultado.Top = btnCalcular.Bottom + marginTop;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtNumero1.Text, out decimal numero1) || !decimal.TryParse(txtNumero2.Text, out decimal numero2))
            {
                MessageBox.Show("Por favor, insira números válidos.");
                return;
            }

            decimal resultado = 0;
            string operacao = cmbOperacao.SelectedItem.ToString();

            switch (operacao)
            {
                case "Adição":
                    resultado = Adicionar(numero1, numero2);
                    break;

                case "Subtração":
                    resultado = Subtrair(numero1, numero2);
                    break;

                case "Multiplicação":
                    resultado = Multiplicar(numero1, numero2);
                    break;

                case "Divisão":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Erro: Divisão por zero não é permitida.");
                        return;
                    }
                    resultado = Dividir(numero1, numero2);
                    break;
            }

            Resultado.Text = $"Resultado: {resultado:F2}";
        }

        private decimal Adicionar(decimal a, decimal b)
        {
            return a + b;
        }

        private decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        private decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        private decimal Dividir(decimal a, decimal b)
        {
            return a / b;
        }
    }
}