using System.Text;

namespace Tamagotchi.Model
{
    public class PokemonAbilities
    {

        public List<string> Abilities { get; set; } = new List<string>();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var ablt in Abilities)
            {
                stringBuilder.AppendLine(ablt);
            }

            return stringBuilder.ToString();
        }
    }
}
