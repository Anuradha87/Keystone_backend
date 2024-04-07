using AutoMapper;
using Keystone.Application.Features.GetAllCourses.Responses;
using Keystone.Domain.Entities;

namespace Keystone.Application.Features.GetAllCourses.Mappers;

public class GetAllCourseMapper :Profile
{
    public GetAllCourseMapper()
    {
        CreateMap<Course, GetAllCourseResponse>();
    }
    
}