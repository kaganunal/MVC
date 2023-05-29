using Core.ETicaretApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Core.ETicaretApp.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        
    }
}
