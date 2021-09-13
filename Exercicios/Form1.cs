using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Exercicios
{
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        //Exercicio 1
        private void btn_Ex1_Converter_Click(object sender, EventArgs e)
        {
            txt_C.Text = ((double.Parse(txt_F.Text) - 32) * 5 / 9).ToString("0#.##");
        }

        //Exercicio 2
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Comp.Text) || String.IsNullOrEmpty(txt_A.Text) || String.IsNullOrEmpty(txt_L.Text))
                MessageBox.Show("insira um valor valido", "Atenção!");
            else
                if (double.Parse(txt_Comp.Text) > 0 && double.Parse(txt_A.Text) > 0 && double.Parse(txt_L.Text) > 0)
                MessageBox.Show("O volume da caixa é " + (double.Parse(txt_Comp.Text) * double.Parse(txt_L.Text) * double.Parse(txt_A.Text)).ToString("##.##"), "Volume");
            else
                MessageBox.Show("insira um valor maior que zero", "Atenção!");
        }

        //Exercicio 3
        private void btn_MediaConsumo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Km_inicio.Text) || String.IsNullOrEmpty(txt_Km_fim.Text) || String.IsNullOrEmpty(txt_consumo.Text))
                MessageBox.Show("insira um valor valido", "Atenção!");
            else
                if (double.Parse(txt_Km_fim.Text) > double.Parse(txt_Km_inicio.Text))
                MessageBox.Show("A média de consumo foi " + ((double.Parse(txt_Km_fim.Text) - double.Parse(txt_Km_inicio.Text)) / double.Parse(txt_consumo.Text)).ToString("##.##") + " km por litro", "Consumo Médio");
            else
                MessageBox.Show("A Quilometragem inicial não pode ser maior que a final", "Atenção!");
        }

        //Exercicio 4
        private void btnTamanho_Click(object sender, EventArgs e)
        {
            txt_Saida.Clear();
            txt_Saida.Text = "O texto contém " + txt_Entrada.TextLength.ToString() + " caracteres.";
        }
        private void btnPalavras_Click(object sender, EventArgs e)
        {
            txt_Saida.Clear();
            txt_Saida.Text = "O texto contém " + txt_Entrada.Text.Split(' ').Length.ToString() + " palavras";
        }
        private void btn_Inverter_Click(object sender, EventArgs e)
        {
            txt_Saida.Clear();
            for (int i = txt_Entrada.Text.Length-1; i >= 0; i--)
                txt_Saida.Text += txt_Entrada.Text[i];
        }



        #region Auxiliares do Exercicio 1
        //faz com que o textBox do exercicio 1 só aceite numeros,  ponto ,sinal - e backspace
        private void txt_F_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                //MessageBox.Show("apenas numeros são permitidos no campo", "Atenção!");
            }
        }
        //faz com que o textBox do exercicio 1 só aceite a tecla backspace
        private void txt_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        #endregion

        #region Auxiliares do Exercicio 2 
        //faz com que o textBox do exercicio 2 só aceite numeros,  ponto e backspace
        private void txt_Comp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        #endregion

        #region Auxiliares do Exercicio 3
        //faz com que o textBox do exercicio 3 só aceite numeros e backspace
        private void txt_Km_inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }



        #endregion


    }
}
