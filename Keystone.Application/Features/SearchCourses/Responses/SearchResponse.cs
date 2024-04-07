namespace Keystone.Application.Features.SearchCourses.Responses;

public class SearchResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Institute { get; set; }
    public string DeliveryMethod { get; set; }
    public string Location { get; set; }
    public int TotalCourses { get; set; }
}

public class  CourseTableResponse
{
    public List<SearchResponse> Courses { get; set; }
    public int TotalCourses { get; set; }
}
