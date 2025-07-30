using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class menu: MonoBehaviour
    {
     
        private static menu instance;
        private menu() 
        {
            Run();
        }
        public static menu Instance => instance ??= new menu();

        public ConsoleKey tecla;

        public override void Update()
        {

            if (!input) return;

            tecla = Console.ReadKey(true).Key;

            switch (tecla) 
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    GameManager.Instance.Menu.visible = false;
                    GameManager.Instance.Menu.input = false;

                    Console.Clear();
                    GameManager.Instance.mapa = Mapa.Instance;
                    GameManager.Instance.mapa.visible = true;
                    GameManager.Instance.mapa.input = true;

                    GameManager.Instance.player1 = new Personagem();
                    GameManager.Instance.player1.visible = true;
                    GameManager.Instance.player1.input = true;

                  
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:

                    break;
            }
        }
        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("""
                --------------------------    
                        1 vamos la
                        2 to fora
                ---------------------------
                """);
        }

    }
}
