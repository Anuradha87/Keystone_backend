using Keystone.Domain.Common;

namespace Keystone.Domain.Entities;

public sealed class Course : BaseEntity
{
    public  string Institute { get; set; }
    
    public  string Name { get; set; }
    
    public  string Category { get; set; }
    
    public  DeliveryMethod DeliveryMethod { get; set; }
    
    public  string Location { get; set; }
    
    public  string Language { get; set; }
    
    public  DateTimeOffset StartDate { get; set; }
    
}