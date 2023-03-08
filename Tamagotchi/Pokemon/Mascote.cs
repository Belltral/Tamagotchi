using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tamagotchi.Pokemon
{
    public class Mascote
    {
        [Display]
        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name}\nAltura: {Heigth}\nPeso: {Weight}\nHabilidades:";
        }
    }
}
