using Core.ETicaretApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ETicaretApp.Domain.Entities
{
    public class Order: BaseEntity
    {
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int CustomerId{ get; set; }

        public virtual ICollection<Product> Products{ get; set; } = new List<Product>();
        public virtual Customer Customer { get; set; } = null!;
    }
}
