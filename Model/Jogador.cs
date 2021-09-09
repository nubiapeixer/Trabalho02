using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02.Model
{
    public static class Jogador
    {
        // Confere se tem palavra repetida
        public static bool ConferePalavras(string palavra, List<string> listaPalavras)
        {
            int conferir = 0;

            foreach (var item in listaPalavras)
            {
                if (item == palavra)
                {
                    conferir = 1;
                    break;
                }
            }

            if (conferir == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static List<int> Resetar()
        {

            return new List<int>();
        }
        public static List<string> Resetar(string a)
        {

            return new List<string>();
        }

        // Gera pontuação
        public static int ConferePontos(string[] vetor)
        {
            int pontos = 0;

            bool naoEncontrado = true;

            List<string> listaFechada = new List<string>(); // Letras inseridas que não podem ser repetidas

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == "A" || vetor[i] == "D")
                {
                    List<string> listaAberta = new List<string>(); 
                    // Caminhos possíveis 

                    listaAberta.Add(Botoes.CacaPalavras[0][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][0]);

                    int confere = 0;

                    // Verifica se tem letra repetida
                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }

                    // Caso não tenha letra repetida, verifica se a próxima letra da palavra está acessível
                    if (confere == 0)
                    {
                        if(i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }
                                              
                    }
                }
                else if (vetor[i] == "E" || vetor[i] == "F")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[0][0]);
                    listaAberta.Add(Botoes.CacaPalavras[1][0]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][2]);
                    listaAberta.Add(Botoes.CacaPalavras[0][2]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }

                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "B" || vetor[i] == "C")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[0][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][2]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "G" || vetor[i] == "I" || vetor[i] == "U")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[0][0]);
                    listaAberta.Add(Botoes.CacaPalavras[0][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[2][1]);
                    listaAberta.Add(Botoes.CacaPalavras[2][0]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "H" || vetor[i] == "J" || vetor[i] == "V")
                {
                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                        naoEncontrado = false;
                            
                        }

                    }
                    
                }
                else if (vetor[i] == "K" || vetor[i] == "L")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[0][2]);
                    listaAberta.Add(Botoes.CacaPalavras[0][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[2][1]);
                    listaAberta.Add(Botoes.CacaPalavras[2][2]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "M" || vetor[i] == "O" || vetor[i] == "Q")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[1][0]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[2][1]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }

                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "N" || vetor[i] == "T" || vetor[i] == "P")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[2][0]);
                    listaAberta.Add(Botoes.CacaPalavras[1][0]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][2]);
                    listaAberta.Add(Botoes.CacaPalavras[2][2]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                else if (vetor[i] == "R" || vetor[i] == "S" || vetor[i] == "Z")
                {
                    List<string> listaAberta = new List<string>();

                    listaAberta.Add(Botoes.CacaPalavras[2][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][1]);
                    listaAberta.Add(Botoes.CacaPalavras[1][2]);

                    int confere = 0;

                    foreach (var item in listaFechada)
                    {
                        if (item == vetor[i])
                        {
                            confere = -1;
                        }
                    }
                    if (confere == 0)
                    {
                        if (i == vetor.Length-1)
                        {
                            naoEncontrado = false;
                        }
                        else
                        {
                            foreach (var item in listaAberta)
                            {
                                if (vetor[i + 1] == item)
                                {
                                    naoEncontrado = false;
                                }
                            }
                        }

                    }
                }
                
                if (naoEncontrado)
                {
                    break;
                }

                naoEncontrado = true;

                listaFechada.Add(vetor[i]);
            }

            for (int i = 0; i < listaFechada.Count; i++)
            {
                pontos = pontos + 1;
            }

            if (pontos % 2 != 0)
            {
                pontos--;
            }

            pontos /= 2;


            return pontos;

        }


    }
}
