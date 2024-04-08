using AutoMapper;
using Keystone.Application.Features.SearchCourses.Responses;
using Keystone.Application.Helpers;
using Keystone.Domain.Entities;

namespace Keystone.Application.Features.SearchCourses.Mappers;

public class SearchCourseMapper : Profile
{
    public SearchCourseMapper()
    {
      
        
        CreateMap<Course, SearchResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Institute, opt => opt.MapFrom(src => src.Institute))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ForMember(dest => dest.DeliveryMethod, opt => opt.MapFrom(src => EnumHelper.GetEnumDescription(src.DeliveryMethod)))
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Institute, opt => opt.MapFrom(src => src.Institute))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ForMember(dest => dest.DeliveryMethod, opt => opt.MapFrom(src => EnumHelper.GetEnumValueFromDescription<DeliveryMethod>(src.DeliveryMethod)));
    }
}