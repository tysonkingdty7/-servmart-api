namespace Domain_Layer.Models
{
    public class ServiceCategory
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
               
        public virtual ICollection<Service> Services { get; set; }
    }

}
