﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;

namespace Domain_Layer.Models
{
    public class User:IdentityUser
    {
        //public virtual Guid ID { get; set; }
        public virtual string FName { get; set; }
        public virtual string LName { get; set; }
        public virtual string SSN { get; set; }
        //public virtual string PhoneNo { get; set; }
        public virtual string Address { get; set; }
        //public virtual string Username { get; set; }
        //public virtual string Email { get; set; }
        //public virtual byte[] PasswordHash { get; set; }
        //public virtual byte[] PasswordSalt { get; set; }
        public virtual string ProfilePic { get; set; }
        public virtual Guid RoleID { get; set; }
               

        public virtual  Shop Shop { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<RequestOffer> RequestOffer { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }



    }
}
