namespace Domain_Layer.Models
{
    public class Service
    {
        public virtual Guid ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Discription { get; set; }
        public virtual float Rate { get; set; }
        public virtual decimal ExpectedSalary { get; set; }
        public virtual Guid CategoryID { get; set; }
        public virtual Guid ProviderID { get; set; }
               
        public virtual User User { get; set; }
        public virtual ServiceCategory ServiceCategory { get; set; }
        public virtual ICollection<ServiceRate> ServiceRates { get; set; }

    }
}
