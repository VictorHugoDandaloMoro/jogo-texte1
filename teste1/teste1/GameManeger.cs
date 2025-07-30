using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{

    public class GameManager : MonoBehaviour
    {
       


        private static GameManager instance;
        private GameManager() 
        {
            Run();
        }

        public static GameManager Instance => instance ??= new GameManager();

        public menu Menu;
        public Mapa mapa;
        public Personagem player1;

        public override void Start()
        {
            Menu = menu.Instance;
            Menu.visible = true;
            Menu.input = true;
            // Aqui vai entrar o menu de vocês

        }

        public override void Update()
        {
            Draw();
        }


        public override void Draw()
        {
            if (mapa != null && mapa.visible) mapa.Draw();
            if (player1 != null && player1.visible) player1.Draw();
            if (Menu != null && Menu.visible) Menu.Draw();
        }
        /* public void menu()
         {
             string tecla;

             Console.WriteLine("""
                 --------------------------    
                         1 vamos la
                         2 to fora
                 ---------------------------
                 """);
             tecla = Console.ReadLine();

             switch (tecla)
             {
                 case "1":
                     Console.WriteLine(". -- / ..- -- / ..-. ..- - ..- .-. --- / -. --- / -- ..- .. - --- / -.. .. ... - .- -. - . --..-- / ..- -- / --. .-. ..- .--. --- / -.. . / . -. - ..- ... .. .- ... - .- / -.. . / - . -.-. -. --- .-.. --- --. .. .- / --.- ..- . / -. --- / -.-. --- ... - ..- -- .- / ... .- .. .-. / -- ..- .. - --- / -.. .- / ..-. .-. . -. - . / -.. --- / -.-. --- -- .--. ..- - .- -.. --- .-. . ... --..-- / ...- .- -- / .- .--- ..- -.. .- .-. / ..- -- / -.. --- ... / ... . ..- ... / .- -- .. --. --- ... / -.. --- / --. .-. ..- .--. --- / -.. . / .- -- .. --. --- ... / -.. . .-.. . ... / .- / ... . / -- ..- -.. .- .-. / .--. .- .-. .- / -.-. .- ... .- / -.. . / ... . ..- / - .- - .- .-. .- ...- / --.- ..- . / . .-. .- / ..- -- / ..-. .. .-.. --- ... --- ..-. --- / . / .--. . -. ... .- -.. --- .-.");
                     break;

                 case "2":
                     Console.WriteLine("para cima");
                     break;
             }


             Console.WriteLine("""
                 --------------------------    
                         1 interessante  
                         2 e dai
                 ---------------------------
                 """);
             tecla = Console.ReadLine();

             switch (tecla)
             {
                 case "1":
                     Console.WriteLine("/ -- ..- .. - --- / .. -- .--. --- .-. - .- -. - . / .--. .- .-. .- / ...- .- .-. .. --- ... / .--. .- .. ... . ... --..-- / .-.. ..- --. .- .-. . ... / . / -.-. --- .. ... .- ... / -- .- .. ... / --.- ..- . / ..-. --- .. / -- --- .-. - --- / -. --- / ... . ..- / -.-. .- .-. .-. --- / .- / -.-. .- -- .. -. .... --- / -.. . / -.-. .- ... .- / ...- --- .-.. - .- -. -.. --- / -.. . / ..- -- .- / .-. . ..- -. .. .- -- / -.. --- / - .-. .- - .- -.. --- / -.-. --- --- .--. . .-. .- --- / .--- ..- -. - --- / .- / --- -. ..- /");
                     break;
                 case "2":
                     Console.WriteLine(" vc quer saber mais da estoria ou nao");
                     break;

             }
             tecla = Console.ReadLine();
             switch (tecla)
             {
                 case "1":
                     Console.WriteLine("/ -- ..- .. - --- / .. -- .--. --- .-. - .- -. - . / .--. .- .-. .- / ...- .- .-. .. --- ... / .--. .- .. ... . ... --..-- / .-.. ..- --. .- .-. . ... / . / -.-. --- .. ... .- ... / -- .- .. ... / --.- ..- . / ..-. --- .. / -- --- .-. - --- / -. --- / ... . ..- / -.-. .- .-. .-. --- / .- / -.-. .- -- .. -. .... --- / -.. . / -.-. .- ... .- / ...- --- .-.. - .- -. -.. --- / -.. . / ..- -- .- / .-. . ..- -. .. .- -- / -.. --- / - .-. .- - .- -.. --- / -.-. --- --- .--. . .-. .- --- / .--- ..- -. - --- / .- / --- -. ..- /");
                     break;

             }


         }*/
    }

}
