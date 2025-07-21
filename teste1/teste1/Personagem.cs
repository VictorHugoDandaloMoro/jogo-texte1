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
        public vector2 pos = new vector2(1, 1);

        public Personagem(char[,] mapa) { 
            this.mapa  = mapa; 
        }

        public void Movimentar(ConsoleKey tecla)
          
        {

            int tempx = pos.x;
            int tempy = pos.y;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    x=pos.left;
                    break ;
                case ConsoleKey.D:
                    x = pos.left;
                    break ;
                    
                case ConsoleKey.W:
                    y= pos.left;
                    break ;
                    
                case ConsoleKey.S:
                    y = pos.left;
                    break;
            }

            }


        }

    }

