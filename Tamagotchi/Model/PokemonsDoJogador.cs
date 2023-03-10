

namespace Tamagotchi.Model
{
    public class PokemonsDoJogador
    {
        public List<string> Pokemons { get; set; }

        public void AddPoke(string poke)
        {
            Pokemons.Add(poke);
        }

        
    }
}
