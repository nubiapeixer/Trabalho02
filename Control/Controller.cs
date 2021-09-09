using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02.Model;

namespace Trabalho_02.Control
{
    public static class Controller
    {
        // Confere se o campo não está vazio 
        public static bool Confere(string palavra)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Limpa as listas de pontos e palavras
        public static List<int> Resetar()
        {
            return Jogador.Resetar();
        }
        public static List<string> Resetar(string a)
        {
            return Jogador.Resetar(a);
        }

        
        public static bool ConfereRepetida(string palavra, List<string> listaPalavras)
        {
            return Jogador.ConferePalavras(palavra, listaPalavras);
        }

        public static int ConferePontos(string[] vetor)
        {
            return Jogador.ConferePontos(vetor);
        }
    }
}
