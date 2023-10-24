namespace Domain_Layer.Models
{
    public class ServiceRate
    {
        public virtual Guid ID { get; set; }
        public virtual Guid ServiceID { get; set; }
        public virtual Guid UserID { get; set; }
        public virtual string Message { get; set; }
        public virtual float NominateToOthers { get; set; }
        public virtual float WorkQuality { get; set; }
        public virtual float RespectDeliveryTime { get; set; }
               
        public virtual User User { get; set; }
        public virtual Service Service { get; set; }
    }
}
