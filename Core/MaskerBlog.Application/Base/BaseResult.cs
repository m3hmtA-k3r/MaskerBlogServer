using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaskerBlog.Application.Base;

public class BaseResult<T>
{
    public T? Data { get; set; }

    public IEnumerable<Error>? Errors { get; set; }

    [JsonIgnore]
    public bool IsSuccess => Errors == null || !Errors.Any();

    [JsonIgnore]
    public bool IsFailure => !IsSuccess;


    public static BaseResult<T> Success(T data)
    {
        return new BaseResult<T> { Data = data };
    }

    public static BaseResult<T> Fail(string errorMessage)
    {
        return new BaseResult<T> { 
            Errors = [new Error { ErrorMessage = errorMessage } ]
        };
    }

    public static BaseResult<T> Fail()
    {
        return new BaseResult<T>
        {
            Errors = [new Error { ErrorMessage = "A - An unexpected system error has occurred." }]
        };
    }

    public static BaseResult<T> Fail(IEnumerable<IdentityError> errors)
    {
        return new BaseResult<T>
        {
            Errors = errors.Select(error => new Error { PropertyName = error.Code, ErrorMessage = error.Description })
        };
    }

    public static BaseResult<T> Fail(IEnumerable<string> errors)
    {
        return new BaseResult<T>
        {
            Errors = errors.Select(error => new Error { ErrorMessage = error })
        };
    }

    public static BaseResult<T> Notfound(string errorMessage)
    {
        return new BaseResult<T>
        {
            Errors = [new Error { ErrorMessage = errorMessage }]
        };
    }
}

public class Error
{
    public string? PropertyName { get; set; }
    public string? ErrorMessage { get; set; }
}