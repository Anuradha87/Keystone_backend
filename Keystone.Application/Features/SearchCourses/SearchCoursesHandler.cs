using AutoMapper;
using Keystone.Application.Features.GetAllCourses.Responses;
using Keystone.Application.Features.SearchCourses.Requests;
using Keystone.Application.Features.SearchCourses.Responses;
using Keystone.Application.Repositories;
using Keystone.Domain.Entities;
using MediatR;

namespace Keystone.Application.Features.SearchCourses;

public class SearchCoursesHandler(ICourseRepository courseRepository, IMapper mapper)
    : IRequestHandler<SearchQueryRequest, CourseTableResponse>
{
    public async Task<CourseTableResponse> Handle(SearchQueryRequest request,
        CancellationToken cancellationToken)
    {
        List<Course> courses;
        var coursesQuery = await courseRepository.Query(cancellationToken);
        var totalCourses = coursesQuery.Count();
        if (string.IsNullOrEmpty(request.Query))
            courses = coursesQuery.Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();
        else
        {
            courses = coursesQuery
                .Where(x =>
                    x.Name.ToLower().Contains(request.Query.ToLower()) ||
                    x.Institute.ToLower().Contains(request.Query.ToLower()) ||
                    x.Location.ToLower().Contains(request.Query.ToLower()))
                .ToList();
            totalCourses = courses.Count();

            courses = courses.Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();
        }

        var mappedResponse = mapper.Map<List<SearchResponse>>(courses);

        return new CourseTableResponse
        {
            Courses = mappedResponse,
            TotalCourses = totalCourses
        };
    }
}