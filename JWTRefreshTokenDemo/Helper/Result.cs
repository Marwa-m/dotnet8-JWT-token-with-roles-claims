﻿namespace JWTRefreshTokenDemo.Helper;


public class Result
{
    // Properties
    public bool IsSuccess { get; set; }
    public string Message { get; set; }

    // Static helper methods for creating success and failure results

    public static Result Failure(string message) => new Result { IsSuccess = false, Message = message };
    public static Result Success(string message = null) => new Result { IsSuccess = true, Message = message };
}

public class Result<T> 
{
    // Properties
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }

    // Static helper methods for creating success and failure results
    public static Result<T> Failure(string message) => new Result<T> { IsSuccess = false, Message = message };
    public static Result<T> Success(T? data = default, string message = null) => new Result<T> { IsSuccess = true, Message = message, Data = data };
}