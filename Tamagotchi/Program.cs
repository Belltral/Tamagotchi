using Tamagotchi.Controller;
using Tamagotchi.View;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //TamagotchiView adocao = new TamagotchiView();
            //Console.WriteLine(adocao);
            //adocao.MenuPrincipal();
            new TamagotchiController().Jogo();


        }       
    }
}