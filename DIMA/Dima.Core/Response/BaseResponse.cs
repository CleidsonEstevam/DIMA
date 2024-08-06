using System.Text.Json.Serialization;

namespace Dima.Core.Response
{
    public class BaseResponse
    {
        private readonly int _statusCode;

        [JsonConstructor]
        public BaseResponse() => _statusCode = 200;

        public BaseResponse(object? data)
        {
            Data = data;
        }

        public BaseResponse(Object? data, int status, string message)
        {
            Data = data;
            _statusCode = status;
            Message = message;
        }

        public Object? Data { get; set; }

        public string Message { get; set; } = string.Empty;

        [JsonIgnore]
        public bool IsSuccess => _statusCode is >= 200 and <= 299;
    }
}
