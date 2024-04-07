using Keystone.Application.Features.GetAllCourses.Responses;
using MediatR;

namespace Keystone.Application.Features.GetAllCourses.Requests;

public sealed record GetAllCoursesRequest : IRequest<List<GetAllCourseResponse>>;
