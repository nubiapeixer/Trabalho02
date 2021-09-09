using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02.Model
{
    public static class Botoes
    {
        public static string[][] CacaPalavras { get; set; }


        // Gera aleatoriamente os botões
        public static string Botao(string x, string y)
        {
            int escolha = 0;
            Random ran = new Random();
            if ((escolha = ran.Next(1, 3)) == 1)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public static string Botao(string x, string y, string z)
        {
            int escolha = 0;
            Random ran = new Random();
            if ((escolha = ran.Next(1, 4)) == 1)
            {
                return x;
            }
            else if((escolha = ran.Next(1, 4)) == 2)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
    }
}
