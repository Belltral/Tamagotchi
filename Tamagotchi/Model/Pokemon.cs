using System.Text;

namespace Tamagotchi.Model
{
    public class Pokemon
    {
        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; } = new List<PokemonAbilities>();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Nome do Pokemon: " + Name);
            stringBuilder.AppendLine("Altura: " + Heigth.ToString());
            stringBuilder.AppendLine("Peso: " + Weight.ToString());
            stringBuilder.AppendLine("Habilidades:");
            foreach (var poke in Abilities)
            {
                stringBuilder.Append(poke.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}