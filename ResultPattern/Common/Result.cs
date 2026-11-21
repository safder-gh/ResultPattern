namespace ResultPattern.Common
    {
    public class Result<T>
        {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public T? Value { get; }
        public Error? Error { get; }
        private Result(bool isSuccess, Error? error, T? value)
            {
            IsSuccess = isSuccess;
            Error = error;
            Value = value;
            }
        public static Result<T> Success(T value) => new Result<T>(true, null, value);
        public static Result<T> Failure(Error error) => new Result<T>(false, error, default(T)  );
        }
    }