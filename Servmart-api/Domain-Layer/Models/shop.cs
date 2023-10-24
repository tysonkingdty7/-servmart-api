using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Shop
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Logo { get; set; }
               
        public virtual User Owner { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
