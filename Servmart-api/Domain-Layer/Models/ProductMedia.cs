namespace Domain_Layer.Models
{
    public class ProductMedia
    {
        public virtual Guid ID { get; set; }
        public virtual string MeadiUrl { get; set; }
        public virtual Guid ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}