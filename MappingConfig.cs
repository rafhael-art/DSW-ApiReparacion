using ApiReparacion.Models;
using AutoMapper;

namespace ApiReparacion
{
    public class MappingConfig
    {
        public static MapperConfiguration registerReparacion()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<DetalleDto, DetalleReparacion>();
                config.CreateMap<DetalleReparacion, DetalleDto>();
            });
            return mappingConfig;
        }
    }
}
