using Core.ETicaretApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ETicaretApp.Domain.Entities
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        [NotMapped]
        public string FullName { get { return Name + " " + Surname; } }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        

    }
}
