namespace Domain_Layer.Models
{
    public class RequestOffer
    {
        public virtual Guid ID { get; set; }
        public virtual Guid ProviderID { get; set; }
        public virtual int State { get; set; }
        public virtual bool IsDirect { get; set; }
        public virtual Guid RequestID { get; set; }
               
        public virtual Request Request { get; set; }
        public virtual User User { get; set; }
    }
}
