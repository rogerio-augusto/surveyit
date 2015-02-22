using AutoMapper;
using SurveyIt.Domain.Entities;
using SurveyIt.MVC.ViewModels;

namespace SurveyIt.MVC.AutoMapper
{
    public class EntitiesMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Hotsite, HotsiteViewModel>().ReverseMap();
            Mapper.CreateMap<Step, StepViewModel>().ReverseMap();
        }
    }
}