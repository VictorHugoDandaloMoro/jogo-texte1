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

        public string tecla;

        public override void Update()
        {
            Draw();
            if (!input) return;

            tecla = Console.ReadLine();

            switch (tecla) 
            {
                case "1":
                    GameManager.Instance.mapa = Mapa.Instance;
                    GameManager.Instance.mapa.visible = true;
                    GameManager.Instance.mapa.input = true;

                    GameManager.Instance.player1 = new Personagem();
                    GameManager.Instance.player1.visible = true;
                    GameManager.Instance.player1.input = true;

                    GameManager.Instance.Menu.visible = false;
                    GameManager.Instance.Menu.input = false;
                    break;
                case "2":

                    break;
            }
        }
        public override void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("""
                --------------------------    
                        1 vamos la
                        2 to fora
                ---------------------------
                """);
            tecla = Console.ReadLine();
        }

    }
}
