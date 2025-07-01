using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class Personagem
    {
        public int x = 1;
        public int y = 1;
        char forma = '@';
        char[,] mapa;

        public Personagem(char[,] mapa) { 
            this.mapa  = mapa; 
        }

        public void Movimentar(ConsoleKey tecla)
          
        {

            int tempX = x;
            int tempY = y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX--;
                    break ;
                case ConsoleKey.D:
                    tempX++;
                    break ;
                    
                case ConsoleKey.W:
                    tempY--;
                    break ;
                    
                case ConsoleKey.S:
                    tempY++;
                    break;
            }

            if (mapa[tempX, tempY] != '#')
            {
                mapa[x, y] = ' ';
                mapa[tempX, tempY] = '@';
                x = tempX;
                y = tempY;
            }


        }

    }
}
