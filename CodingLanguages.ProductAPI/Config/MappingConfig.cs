using AutoMapper;
using CodingLanguages.API.Data.ValueObjects;
using CodingLanguages.API.Model;

namespace CodingLanguages.API.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(cfg =>{
                cfg.CreateMap<LanguageVO, Language>();
                cfg.CreateMap<Language, LanguageVO>();
            });

            return mappingConfig;
        }
    }
}
