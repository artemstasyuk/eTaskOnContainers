using System.Net;

namespace eTaskOnContainers.Domain.Errors;

public interface IApplicationException
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get; }
    public string ProblemDetails { get; }
}