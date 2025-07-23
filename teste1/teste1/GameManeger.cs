using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{

    class GameManager : MonoBehaviour
    {
        private GameManager() { }
        private static GameManager instance;
        public static GameManager Instance => instance ??= new GameManager();

        public override void Start()
        {
            menu();
            // Aqui vai entrar o menu de vocês

        }


        public char[,] mapa;
        public int largura = 60;
        public int altura = 30;

        public bool jogando = false;
        public Personagem player1;
       
        public void menu()
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


        }
}

}
