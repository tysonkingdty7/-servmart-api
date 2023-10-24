using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Product
    {
        public virtual Guid ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int Stoke { get; set; }
        public virtual Guid CategoryID { get; set; }
        public virtual Guid ShopID { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual ICollection<ProductMedia> ProductMedias { get; set; }
        public virtual ICollection<ProductRate> ProductRates { get; set; }
    }
}
