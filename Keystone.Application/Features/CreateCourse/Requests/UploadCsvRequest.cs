using MediatR;
using Microsoft.AspNetCore.Http;

namespace Keystone.Application.Features.CreateCourse.Requests;

public class UploadCsvRequest : IRequest<bool>
{
    public IFormFile CsvFile { get; set; }
}
   