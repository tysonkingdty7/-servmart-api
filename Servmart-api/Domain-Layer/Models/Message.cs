
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Message
    {
        public virtual Guid ID { get; set; }
        public virtual Guid ChatId { get; set; }
        public virtual Guid SenderId { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Chat Chat { get; set; }
        public virtual ICollection<MessageMedia> MessageMedias { get; set; }

    }
}
