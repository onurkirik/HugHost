namespace HugHost.Application.Common.Responses;

public class QueryResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; } // There is no record.
    public List<string>? Errors { get; set; } // validation messages
    public T? Data { get; set; }

    public static QueryResponse<T> Ok(T data)
    {
        return new QueryResponse<T> { Success = true, Data = data };
    }

    public static QueryResponse<T> Fail(string message)
    {
        return new QueryResponse<T> { Success = false, Message = message };
    }

    public static QueryResponse<T> Fail(IEnumerable<string> errors)
    {
        return new QueryResponse<T>
        {
            Success = false,
            Errors = errors.ToList()
        };
    }

    public static QueryResponse<T> NotFound(string? message = null)
    {
        return new QueryResponse<T>
        {
            Success = false,
            Message = message ?? "There is no record."
        };
    }
}