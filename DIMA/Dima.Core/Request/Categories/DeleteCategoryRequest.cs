using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima.Core.Request.Categories
{
    public class DeleteCategoryRequest : BaseRequest
    {
        public long Id { get; set; }
    }
}
