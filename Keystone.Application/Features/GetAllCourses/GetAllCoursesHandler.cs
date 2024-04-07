using AutoMapper;
using Keystone.Application.Features.GetAllCourses.Requests;
using Keystone.Application.Features.GetAllCourses.Responses;
using Keystone.Application.Repositories;
using MediatR;

namespace Keystone.Application.Features.GetAllCourses;

public class GetAllCoursesHandler(ICourseRepository courseRepository, IMapper mapper)
    : IRequestHandler<GetAllCoursesRequest, List<GetAllCourseResponse>>
{
    public async Task<List<GetAllCourseResponse>> Handle(GetAllCoursesRequest request, CancellationToken cancellationToken)
    {
        var users = await courseRepository.GetAll(cancellationToken);
        return mapper.Map<List<GetAllCourseResponse>>(users);
    }
}