using AutoMapper;
using Tamagotchi.Controller;
using Tamagotchi.Model;
using Tamagotchi.Model.Mapping;
using Tamagotchi.View;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            new TamagotchiController().Jogo();

            //new TamagotchiController().Adotar();
        }
    }
}