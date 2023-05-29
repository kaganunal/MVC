using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ETicaretApp.Domain.Entities.General
{
    public abstract class BaseEntity
    {
        public int Id{ get; set; }
        public Guid? UId { get; set; } = Guid.NewGuid();
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        /*
        public BaseEntity()
        {
            UId = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        */
    }
}
