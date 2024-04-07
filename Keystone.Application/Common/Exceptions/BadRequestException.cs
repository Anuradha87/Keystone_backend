namespace Keystone.Application.Common.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message, string[] errors) : base(message)
    {
        Errors = errors;
    }

    public BadRequestException(string[] errors) : base("Multiple errors occurred. See error details.")
    {
        Errors = errors;
    }

    public string[] Errors { get; set; }
}