using Keystone.Application.Features.CreateCourse.Requests;
using Keystone.Application.Features.GetAllCourses.Requests;
using Keystone.Application.Features.GetAllCourses.Responses;
using Keystone.Application.Features.SearchCourses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Keystone.Controllers;

[ApiController]
[Route("api/course")]
public class CourseController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<GetAllCourseResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await mediator.Send(new GetAllCoursesRequest(), cancellationToken);
        return Ok(response);
    }
    
    [HttpGet ("search")]
    public async Task<ActionResult<List<GetAllCourseResponse>>> Search([FromQuery] SearchQueryRequest request,CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
     
    [HttpPost("upload")]
    public async Task<ActionResult<bool>> Create(UploadCsvRequest request,
        CancellationToken cancellationToken)
    {
        if (request?.CsvFile == null || request.CsvFile.Length == 0)
        {
            return BadRequest("No CSV file uploaded.");
        }
        
        var response = await mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    
}