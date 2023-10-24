using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain_Layer.Models
{
    public class Chat
    {
        public virtual Guid ID { get; set; }
        public virtual Guid FirstUserId { get; set; }
        public virtual Guid SecondUserId { get; set; }
        public virtual Guid RequestID { get; set; }

        public virtual User User { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

    }
}
