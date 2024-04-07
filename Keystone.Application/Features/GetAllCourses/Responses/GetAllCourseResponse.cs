using Keystone.Domain.Entities;

namespace Keystone.Application.Features.GetAllCourses.Responses;

public record GetAllCourseResponse
{
    public Guid Id { get; set; }
    
    public  string Institute { get; set; }
    
    public  string Name { get; set; }
    
    public  string Category { get; set; }
    
    public  DeliveryMethod DeliveryMethod { get; set; }
    
    public  string Location { get; set; }
    
    public  string Language { get; set; }
    
    public  DateTimeOffset StartDate { get; set; }
    
}