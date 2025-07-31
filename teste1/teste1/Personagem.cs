using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{   
    public class Personagem : MonoBehaviour
    {
        public bool pegochave = false;
        
        char forma = '@';
       
        public vector2 pos = new vector2(1, 1);


        private static Personagem instance;


        public Personagem()
        {
            Run();
        }

        public static Personagem Instance => instance ??= new Personagem();

        public override void Update()
        {
            if ( input != true ) return;

            ConsoleKey tecla;
            tecla = Console.ReadKey(true).Key;
            Movimentar(tecla);
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


            if (Mapa.Instance.mapa[x, y] == '?')
            {
                pegochave = true;
            }

            if (Mapa.Instance.mapa[x,y] == '|' && pegochave == true) 
            {
                Mapa.Instance.visible = false;
                Console.Clear();

            }


        }



        public override void Draw() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(forma);
            Console.ResetColor();

        }


    }

}

