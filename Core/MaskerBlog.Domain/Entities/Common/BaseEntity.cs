using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskerBlog.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }// Ne zaman Oluşturuldu
        public DateTime UpdatedAt { get; set; }// Ne zaman Güncellendi
    }
}
