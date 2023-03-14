using AutoMapper;


namespace Tamagotchi.Model.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, Mascote>();
        }
    }
}
