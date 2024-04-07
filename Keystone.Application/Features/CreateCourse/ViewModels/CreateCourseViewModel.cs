using Keystone.Domain.Entities;

namespace Keystone.Application.Features.CreateCourse.ViewModels;

public class CreateCourseViewModel
{
    public Guid CourseId { get; set; }
    
    public  string InstituteName { get; set; }
    
    public  string CourseName { get; set; }
    
    public  string Category { get; set; }
    
    public  string  DeliveryMethod { get; set; }
    
    public  string Location { get; set; }
    
    public  string Language { get; set; }
    
    public  DateTimeOffset StartDate { get; set; }
}