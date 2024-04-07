using AutoMapper;
using Keystone.Application.Features.CreateCourse.ViewModels;
using Keystone.Application.Helpers;
using Keystone.Domain.Entities;

namespace Keystone.Application.Features.CreateCourse.Mappers;

public class BulkCreateMapper : Profile
{
    public BulkCreateMapper()
    {
        CreateMap<Course, CreateCourseViewModel>()
            .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.InstituteName, opt => opt.MapFrom(src => src.Institute))
            .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.DeliveryMethod, opt => opt.MapFrom(src => EnumHelper.GetEnumDescription(src.DeliveryMethod)))
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CourseId))
            .ForMember(dest => dest.Institute, opt => opt.MapFrom(src => src.InstituteName))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CourseName))
            .ForMember(dest => dest.DeliveryMethod, opt => opt.MapFrom(src => EnumHelper.GetEnumValueFromDescription<DeliveryMethod>(src.DeliveryMethod)));
    }

}