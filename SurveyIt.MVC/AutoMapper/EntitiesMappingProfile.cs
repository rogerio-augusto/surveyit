using AutoMapper;
using SurveyIt.Core.DomainEntities;
using SurveyIt.MVC.ViewModels;

namespace SurveyIt.MVC.AutoMapper
{
    public class EntitiesMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Hotsite, HotsiteViewModel>()
                  .ForMember(dest => dest.Steps, opt => opt.MapFrom(src => src.Steps))
                  .ReverseMap();

            Mapper.CreateMap<Step, StepViewModel>()
                  .ForMember(dest => dest.Hotsite, opt => opt.MapFrom(src => src.Hotsite))
                  .ReverseMap();

            Mapper.CreateMap<Question, QuestionViewModel>()
                  .ForMember(dest => dest.Alternatives, opt => opt.MapFrom(src => src.Alternatives))
                  .ReverseMap();

            Mapper.CreateMap<Alternative, AlternativeViewModel>()
                  .ForMember(dest => dest.Question, opt => opt.MapFrom(src => src.Question))
                  .ReverseMap();
        }
    }
}