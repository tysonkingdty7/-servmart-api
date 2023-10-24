namespace Domain_Layer.Models
{
    public class Request
    {
        public virtual Guid ID { get; set; }
        public virtual Guid CleintID { get; set; }
        public virtual string Details { get; set; }
        public virtual decimal ExpectSalary { get; set; }
        public virtual int State { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual float RateValue { get; set; }
        public virtual string RateMassage { get; set; }
               
        public virtual User User { get; set; }
        public virtual ICollection<RequestMedia> Media { get; set; }
        public virtual ICollection<RequestOffer> RequestOffer { get; set; }
    }
}
