using MaskerBlog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskerBlog.Domain.Entities
{
    public class SubComment : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string Body { get; set; }
        public DateTime CommentDate { get; set; }

        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }

        
    }
}
