using MyWebApi.Entities.Common;

namespace MyWebApi.Entities.ResponseModels
{
    public class ApiResponse<T>
    {
        public Status Status { get; set; }
        public T Data { get; set; }
    }
}