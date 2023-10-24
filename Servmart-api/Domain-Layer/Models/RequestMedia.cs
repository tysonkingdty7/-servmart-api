namespace Domain_Layer.Models
{
    public class RequestMedia
    {
        public  virtual Guid ID { get; set; }
        public  virtual string MediaUrl { get; set; }
        public  virtual Guid RequestID { get; set; }
                
        public  virtual Request Request { get; set; }
    }
}
