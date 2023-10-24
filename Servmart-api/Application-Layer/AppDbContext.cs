using Domain_Layer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<Chat> Chat { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MessageMedia> MessageMedia { get; set; }
        public DbSet<Product> Product { get; set; }

      public DbSet<ProductCategory> ProductCategorie { get; set; }
        public DbSet<ProductMedia> productMedia {  get; set; }
        public DbSet<ProductRate> ProductRate { get; set; }
        public DbSet<Request>Request { get; set; }
        public DbSet<RequestMedia> RequestMedia { get; set; }
        public DbSet<RequestOffer> RequestOffer { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceCategory> ServiceCategorie { get; set; }
        public DbSet<ServiceRate> ServiceRate { get; set; }
        public DbSet<Shop> Shop { get; set; }



    }
}
