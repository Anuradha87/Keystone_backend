using AutoMapper;
using Keystone.Application.Features.SearchCourses.Responses;
using Keystone.Domain.Entities;

namespace Keystone.Application.Features.SearchCourses.Mappers;

public class SearchCourseMapper : Profile
{
    public SearchCourseMapper()
    {
        CreateMap<Course, SearchResponse>()
            .ReverseMap();
    }
}