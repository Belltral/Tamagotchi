

using System.Text;

namespace Tamagotchi.Model
{
    public class Mascote
    {
        public List<Pokemon> Pokemons { get; set; }

        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; } = new List<PokemonAbilities>();
        public string Fome { get; set; }
        public string Humor { get; set; }
        public string Sono { get; set; }

        
        public void AddPoke(Pokemon poke)
        {
            
        }
        

        public void Alimentar()
        {
            
        }

        public void Brincar()
        {

        }

        public void Dormir()
        {

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Name);
            stringBuilder.AppendLine(Heigth.ToString());
            stringBuilder.AppendLine(Abilities.ToString());
            return stringBuilder.ToString();
        }
    }
}
