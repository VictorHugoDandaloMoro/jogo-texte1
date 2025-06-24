using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class CriptografiaEreditaria
    {
        static char[,] mapa;
        static int largura = 50;
        static int altura = 25;
        static int playerX = 1;
        static int playerY = 1;
        static bool jogando = true;
        static void Main()
        {
            Console.Clear();

            // aqui vai entrar o menu de voces
            jogar();
        }
        static void jogar()
        {
            IniciarMapa();

            while (jogando)
                {
                Console.Clear();
                DesenharMapa();

                var tecla = Console.ReadKey(true).Key;

                AtualizarPosicao(tecla); 
            }

        }
        static void IniciarMapa()
        {

            mapa = new char[largura, altura];

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // ultima possição do vetor é tamanho - 1
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)//se for q borda
                    {
                        mapa[x, y] = '#';


                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }
            }
            mapa[playerX, playerY] = '@';

            for (int I = 0; I < 5; I++)
            {
                mapa[I,2 ] = '#';

            }
            mapa[6, 2] = '#';
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





        }

        static void DesenharMapa()
        {
            for (int y = 0;  y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write( mapa[x,y] );
                }
                Console.WriteLine();
            }
        }

        static void AtualizarPosicao(ConsoleKey tecla) 
        {  
            
            int tempX = playerX;
            int tempY = playerY;

            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX--;
                    break;
                case ConsoleKey.D:
                    tempX++;
                    break;
                case ConsoleKey.W:
                    tempY--;
                    break;
                case ConsoleKey.S:
                    tempY++;
                    break;
            }

            if ( mapa [tempX, tempY] != '#')
            {
                mapa[playerX, playerY] = ' ';
                mapa[tempX, tempY] = '@';
                playerX= tempX;
                playerY= tempY;
            }


        }
         
    }
}
