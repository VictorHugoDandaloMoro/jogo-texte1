﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class Mapa : MonoBehaviour
    {
        private static Mapa instance;

        private Mapa()
        {
            Run();
        }

        public static Mapa Instance => instance ??= new Mapa();

        public char[,] mapa;
        public int largura = 51;
        public int altura = 27;

        public override void Start()
        {
            mapa = new char[largura , altura];

            string desenhar = """
                #########################################
                #       #   #         ###################                
                ##### #   #   # #####   ######        ###
                #   # ######### ######   ##### ###### ###
                # # # #########    #####   ###      # ###
                # #   ###    #####    ####    ##### # ###
                # ######  ## ##### ##     ### ##### # ###
                # #      ###       ## ### #   ##### # ###
                #   #### #########    ###   ####### # ###
                # ###### ######### ####   ###     # # ###
                # #    # ####      ###  ##### ### # # ###
                #   ## # #### #######  ###### ### # # ###
                ###### #    #       #    #### ### # # ###
                ##     ############ #####     ### # # ###
                ## ##########   #   ####### ##### # # ###
                ##          # # # # #       #####   # ###
                ########### # # # # # ############### ###
                ##          # # # # #       #           #
                ## ########## # # # ####### # #   # ### #
                ##?           #   #         #   #   ### |
                #########################################
                """;

            /*mapa[6, 2] = '#';
            mapa[6, 3] = '#';
            mapa[4, 3] = '#';
            mapa[4, 4] = '#';
            mapa[2, 4] = '#';
            mapa[2, 5] = '#';
            mapa[2, 6] = '#';
            mapa[3, 6] = '#';
            mapa[4, 6] = '#';
            mapa[7, 3] = '#';
            mapa[7, 5] = '#';
            mapa[6, 5] = '#';
            mapa[6, 7] = '#';
            mapa[7, 7] = '#';
            mapa[1, 8] = '#';
            mapa[3, 8] = '#';
            mapa[6, 8] = '#';
            mapa[3, 9] = '#';
            mapa[4, 9] = '#';
            mapa[2, 10] = '#';
            mapa[3, 10] = '#';
            mapa[4, 10] = '#';
            mapa[3, 12] = '#';
            mapa[3, 13] = '#';
            mapa[2, 14] = '#';
            mapa[2, 15] = '#';
            mapa[2, 15] = '#';
            mapa[8, 18] = '#';
            mapa[6, 3] = '#';
            mapa[7, 3] = '#';
            mapa[8, 3] = '#';
            mapa[9, 3] = '#';
            mapa[10, 3] = '#';
            mapa[11, 3] = '#';
            mapa[11, 4] = '#';
            mapa[8, 5] = '#';
            mapa[9, 5] = '#';
            mapa[8, 7] = '#';
            mapa[9, 7] = '#';
            mapa[10, 7] = '#';
            mapa[11, 7] = '#';
            mapa[11, 6] = '#';
            mapa[13, 5] = '#';
            mapa[13, 3] = '#';
            mapa[13, 7] = '#';
            mapa[15, 5] = '#';
            mapa[15, 6] = '#';
            mapa[4, 12] = '#';
            mapa[5, 12] = '#';
            mapa[6, 12] = '#';
            mapa[6, 11] = '#';
            mapa[8, 11] = '#';
            mapa[8, 12] = '#';
            mapa[9, 12] = '#';
            mapa[9, 13] = '#';
            mapa[10, 13] = '#';
            mapa[5, 13] = '#';
            mapa[7, 14] = '#';
            mapa[10, 14] = '#';
            mapa[4, 24] = '#';
            mapa[3, 22] = '#';
            mapa[4, 22] = '#';
            mapa[4, 20] = '#';
            mapa[5, 20] = '#';
            mapa[4, 19] = '#';
            mapa[5, 19] = '#';
            mapa[6, 19] = '#';
            mapa[8, 23] = '#';
            mapa[8, 21] = '#';
            mapa[7, 21] = '#';
            mapa[8, 19] = '#';
            mapa[11, 20] = '#';
            mapa[13, 19] = '#';
            mapa[16, 20] = '#';
            mapa[17, 20] = '#';
            mapa[18, 20] = '#';
            mapa[19, 20] = '#';
            mapa[20, 20] = '#';
            mapa[22, 20] = '#';
            mapa[22, 21] = '#';
            mapa[22, 22] = '#';
            mapa[21, 22] = '#';
            mapa[20, 22] = '#';
            mapa[19, 22] = '#';
            mapa[18, 22] = '#';
            mapa[9, 23] = '#';
            mapa[10, 23] = '#';
            mapa[11, 23] = '#';
            mapa[12, 23] = '#';
            mapa[13, 23] = '#';
            mapa[14, 23] = '#';
            mapa[15, 23] = '#';
            mapa[16, 23] = '#';
            mapa[17, 23] = '#';
            mapa[18, 23] = '#';
            mapa[11, 2] = '#';
            mapa[13, 1] = '#';
            mapa[14, 1] = '#';
            mapa[15, 1] = '#';
            mapa[16, 1] = '#';
            mapa[17, 1] = '#';
            mapa[17, 2] = '#';
            mapa[17, 3] = '#';
            mapa[17, 4] = '#';
            mapa[14, 3] = '#';
            mapa[15, 3] = '#';
            mapa[8, 1] = '#';
            mapa[10, 2] = '#';
            mapa[12, 18] = '#';
            mapa[12, 17] = '#';
            mapa[13, 17] = '#';
            mapa[14, 17] = '#';
            mapa[14, 16] = '#';
            mapa[15, 16] = '#';
            mapa[16, 16] = '#';
            mapa[16, 19] = '#';
            mapa[13, 18] = '#';
            mapa[17, 19] = '#';
            mapa[18, 19] = '#';
            mapa[18, 18] = '#';
            mapa[19, 18] = '#';
            mapa[20, 18] = '#';

            for (int I = 2; I < 10; I++)
            {
                mapa[I, 15] = '#';

            }

            for (int I = 15; I < 19; I++)
            {
                mapa[10, I] = '#';

            }
            for (int I = 8; I < 10; I++)
            {
                mapa[I, 19] = '#';

            }
            for (int I = 2; I < 9; I++)
            {
                mapa[I, 17] = '#';

            }
            for (int I = 18; I < 24; I++)
            {
                mapa[2, I] = '#';
            }
            for (int I = 21; I < 25; I++)
            {
                mapa[6, I] = '#';
            }
            for (int I = 7; I < 16; I++)
            {
                mapa[I, 21] = '#';
            }*/
            string[] linhas = desenhar.Split('\n');

            for (int y = 0; y < altura; y++)
            {
                if (y >= linhas.Length) break;

                string linha = linhas[y].TrimEnd();
                for (int x = 0; x < largura; x++)
                {
                    if (x >= linha.Length) 
                    {
                        mapa[x, y] = ' ';
                    }
                    else
                    {
                        mapa[x, y] = linha[x];
                    }
                }
               
            }
        }

       /* public void iniciarMapa()
        {
            Console.Clear();
            mapa = new char[largura, altura];

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    //ultima posição do vetor é tamanho - 1
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)
                    {
                        mapa[x, y] = '#';
                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }
            }


        }*/




        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }

        }



    }
}

  

 