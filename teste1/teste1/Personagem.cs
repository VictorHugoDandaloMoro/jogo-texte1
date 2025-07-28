using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class Personagem : MonoBehaviour
    {
       
        char forma = '@';
       
        public vector2 pos = new vector2(1, 1);


        private static Personagem instance;


        public Personagem()
        {
            Run();
        }

        public static Personagem Instance => instance ??= new Personagem();



        public void Movimentar(ConsoleKey tecla)
        {

            int tempx = pos.x;
            int tempy = pos.y;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.A:
                    x=pos.Left;
                    break ;
                case ConsoleKey.D:
                    x = pos.Right;
                    break ;
                    
                case ConsoleKey.W:
                    y= pos.Up;
                    break ;
                    
                case ConsoleKey.S:
                    y = pos.Down;
                    break;
            }

            if (Mapa.Instance.mapa[x, y] == '#')
            {
                pos.x = tempx;
                pos.y = tempy;
            }


        }


        public override void Draw() 
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(forma);

        }


    }

}

