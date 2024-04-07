using System.Globalization;
using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using Keystone.Application.Features.CreateCourse.Requests;
using Keystone.Application.Features.CreateCourse.ViewModels;
using Keystone.Application.Repositories;
using Keystone.Domain.Entities;
using MediatR;

namespace Keystone.Application.Features.CreateCourse;

public class CreateCoursesHandler(ICourseRepository courseRepository, IMapper mapper, IUnitOfWork unitOfWork)
    : IRequestHandler<UploadCsvRequest, bool>
{
    public Task<bool> Handle(UploadCsvRequest request, CancellationToken cancellationToken)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            HeaderValidated = null,
            Delimiter = ";",
        };
        using var streamReader = new StreamReader(request.CsvFile.OpenReadStream());
        using var csvReader = new CsvReader(streamReader, config);
        var records = csvReader.GetRecords<CreateCourseViewModel>().ToList();

        var courseList = mapper.Map<List<Course>>(records);

        courseRepository.BulkInsert(courseList, cancellationToken);
        unitOfWork.Save(cancellationToken);


        return Task.FromResult(true);
    }
}