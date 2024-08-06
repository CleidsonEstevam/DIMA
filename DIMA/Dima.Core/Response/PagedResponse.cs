using System.Text.Json.Serialization;

namespace Dima.Core.Response
{
    public class PagedResponse : BaseResponse
    {
        [JsonConstructor]
        public PagedResponse(object? data,int totalCount,int currentPage = 1,int pageSize = 25) : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse( object? data,int code = 200,string? message = null) : base(data, code, message)
        {
        }

        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = 25;
        public int TotalCount { get; set; }
    }
}
