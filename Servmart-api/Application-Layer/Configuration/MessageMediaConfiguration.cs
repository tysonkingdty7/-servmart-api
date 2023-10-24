using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Configuration
{
    public class MessageMediaConfiguration : IEntityTypeConfiguration<MessageMedia>
    {
        public void Configure(EntityTypeBuilder<MessageMedia> builder)
        {
            builder.ToTable("MessageMedia", "Chat");
            builder.HasOne(m => m.Message).WithMany(M => M.MessageMedias).HasForeignKey(m => m.MessageID);
        }
    }
}
