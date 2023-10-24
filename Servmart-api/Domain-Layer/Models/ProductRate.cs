using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class ProductRate
    {
        public virtual    Guid ID { get; set; }
        public virtual float Rate { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid ProductId { get; set; }
        public virtual Guid CustomerID { get; set; }
               
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
