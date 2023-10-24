namespace Domain_Layer.Models
{
    public class ProductCategory
    {
        public virtual Guid ID { get; set; }
        public virtual string Catagory { get; set; }

        public virtual ICollection<Product> Prouducts { get; set; }

    }
}