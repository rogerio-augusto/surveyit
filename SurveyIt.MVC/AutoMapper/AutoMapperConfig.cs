using AutoMapper;

namespace SurveyIt.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntitiesMappingProfile>();
            });
        }
    }
}