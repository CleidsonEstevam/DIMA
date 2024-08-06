using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Request.Categories
{
    public class CreateCategoryRequest : BaseRequest
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
