namespace HugHost.Application.Common.Responses;

public class CommandResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public List<string>? Errors { get; set; }
    public T? Data { get; set; }

    public static CommandResponse<T> Ok(T data, string? message = null)
    {
        return new CommandResponse<T> { Success = true, Data = data, Message = message };
    }

    public static CommandResponse<T> Fail(string message)
    {
        return new CommandResponse<T> { Success = false, Message = message };
    }

    public static CommandResponse<T> Fail(IEnumerable<string> errors)
    {
        return new CommandResponse<T>
        {
            Success = false,
            Errors = errors.ToList()
        };
    }
}