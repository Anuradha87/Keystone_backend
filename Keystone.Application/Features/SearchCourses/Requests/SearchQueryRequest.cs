using Keystone.Application.Features.SearchCourses.Responses;
using MediatR;

namespace Keystone.Application.Features.SearchCourses.Requests;

public class SearchQueryRequest : IRequest<CourseTableResponse>
{
    public string  Query { get; set; }
    public int PageSize { get; set; } = 10;
    public int PageNumber { get; set; }
}