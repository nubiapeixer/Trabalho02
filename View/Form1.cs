using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_02.Control;
using Trabalho_02.Model;

namespace Trabalho_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaCacaPalavra();
        }

        private void AtualizaCacaPalavra()
        {
            btn1.Text = Botoes.Botao("A", "D");
            btn2.Text = Botoes.Botao("E", "F");
            btn3.Text = Botoes.Botao("B", "C");
            btn4.Text = Botoes.Botao("G", "I", "U");
            btn5.Text = Botoes.Botao("H", "J", "V");
            btn6.Text = Botoes.Botao("K", "L");
            btn7.Text = Botoes.Botao("M", "O", "Q");
            btn8.Text = Botoes.Botao("N", "T", "P");
            btn9.Text = Botoes.Botao("R", "S", "Z");

            dgPontos.Rows.Clear();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<string> listaPalavras = new List<string>();
        List<int> listaPontos = new List<int>();
        private void btnTentar_Click(object sender, EventArgs e)
        {
            // Gera matriz para inserir as letras do caça-palavras
            string[][] letras = new string[3][];
            for (int i = 0; i < letras.Length; i++)
            {
                letras[i] = new string[3];
            }

            letras[0][0] = btn1.Text;
            letras[0][1] = btn2.Text;
            letras[0][2] = btn3.Text;

            letras[1][0] = btn4.Text;
            letras[1][1] = btn5.Text;
            letras[1][2] = btn6.Text;

            letras[2][0] = btn7.Text;
            letras[2][1] = btn8.Text;
            letras[2][2] = btn9.Text;

            Botoes.CacaPalavras = letras;

            if (Controller.Confere(txtPalavra.Text.ToUpper()))
            {
                if (Controller.ConfereRepetida(txtPalavra.Text.ToUpper(), listaPalavras))
                {
                    string palavra = txtPalavra.Text.ToUpper();
                    listaPalavras.Add(palavra);

                    string[] vetor = new string[palavra.Length];
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        string letra = palavra.Substring(i, 1);

                        vetor[i] = letra;
                    }

                    int pontuacao = (Controller.ConferePontos(vetor));
                    dgPontos.Rows.Add(palavra, pontuacao);
                    listaPontos.Add(pontuacao);

                    pontuacao = 0;

                    foreach (var item in listaPontos)
                    {
                        pontuacao += item;
                    }

                    lblPontos.Text = Convert.ToString(pontuacao);
                }
                else
                {
                    MessageBox.Show("PALAVRA REPETIDA");
                }
            }
            else
            {
                MessageBox.Show("CAMPO VAZIO");
            }
            txtPalavra.Clear();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            AtualizaCacaPalavra();

            listaPontos = Controller.Resetar();
            listaPalavras = Controller.Resetar("a");

            txtPalavra.Clear();
            lblPontos.Text = "";

            MessageBox.Show("NOVO JOGO");

        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPalavra_MouseClick(object sender, MouseEventArgs e)
        {
            txtPalavra.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
