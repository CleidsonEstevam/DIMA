namespace Dima.Core.Request
{
    public abstract class PaginedRequest :  BaseRequest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize{ get; set; } = 25;
    }
}
