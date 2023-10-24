using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;

namespace Domain_Layer.Models
{
    public class UserDTO
    {
        public  string FName { get; set; }
        public  string LName { get; set; }
        public  string SSN { get; set; }
        public  string Email { get; set; }
        public  string Password { get; set; }
        public string Address { get; set; } = null;
        public string ProfilePic { get; set; } = "Profile.png";
        public  string phoneNumber { get; set; }

               

       



    }
}
