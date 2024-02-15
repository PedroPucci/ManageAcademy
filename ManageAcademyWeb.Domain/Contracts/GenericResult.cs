namespace ManageAcademyWeb.Domain.Contracts
{
    public class GenericResult<T>
    {
        public GenericResult(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

        public static GenericResult<T> Ok(string responseMessage = null, T responseData = default)
        {
            return new GenericResult<T>(success: true, message: responseMessage, data: responseData);
        }

        public static GenericResult<T> Error(string responseMessage)
        {
            return new GenericResult<T>(success: false, responseMessage, data: default);
        }
    }
}