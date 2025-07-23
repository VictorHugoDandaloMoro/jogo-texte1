using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class CriptografiaEreditaria
    {
       
        static bool jogando = true;
        static Personagem pl ;
        static void Main()
        {
            Console.Clear();

            // aqui vai entrar o menu de voces
            jogar();
        }
        static void jogar()
        {
            Mapa.Instance.IniciarMapa();
            pl = new Personagem();

            while (jogando)
                {
                Console.Clear();
                Mapa.Instance.DesenharMapa();
                pl.Desenha();

                var tecla = Console.ReadKey(true).Key;

                pl.Movimentar(tecla); 
            }

        }
         
    }
}
