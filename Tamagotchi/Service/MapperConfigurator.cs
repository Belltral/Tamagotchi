using AutoMapper;
using Tamagotchi.Model.Mapping;

namespace Tamagotchi.Service
{
    public static class MapperConfigurator
    {
        public static IMapper ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            return config.CreateMapper();
        }
    }
}
