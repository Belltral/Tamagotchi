

using System.Text;

namespace Tamagotchi.Model
{
    public class Mascote
    {
        //public List<Pokemon> Pokemons { get; set; }

        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; } //= new List<PokemonAbilities>();
        public int Fome { get; set; }
        public int Humor { get; set; }
        public int Sono { get; set; }

        /* Adicionar Pokemon
        public void AddPoke(Pokemon poke)
        {
            
        }
        */

        public Mascote()
        {
            Random random = new Random();
            Fome = random.Next(3, 10);
            Humor = random.Next(3, 10);
            Sono = random.Next(3, 10);
        }

        public void Alimentar()
        {
            Fome++;
        }

        public void Brincar()
        {
            Humor++;
            Fome--;
            Sono--;
        }

        public void Dormir()
        {
            Sono++;
        }

        public bool MascoteVivo()
        {
            return (Fome > 0 && Humor > 0);
        }

        public bool MascoteDormiu()
        {
            return (Sono < 0);
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("\n");
            stringBuilder.AppendLine("Nome:" + Name);
            stringBuilder.AppendLine("Altura: " + Heigth.ToString());
            stringBuilder.AppendLine("Peso: " + Weight.ToString());
            stringBuilder.AppendLine("Habilidades: ");
            foreach (var poke in Abilities)
            {
                stringBuilder.AppendLine(poke.ToString());
            }
            return stringBuilder.ToString();
        }
        
    }
}
