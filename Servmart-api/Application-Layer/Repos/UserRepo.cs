using Domain_Layer.DTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class UserRepo : BaseRepos<User>, IUserRepo
    {
        private readonly AppDbContext _appContext;

        public UserRepo(AppDbContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }

        public async Task<User> GetUser(string userId)
           => await _appContext.Users.FirstOrDefaultAsync(y => y.Id==userId);
        
        

        public async Task<User> Register(UserDTO userDTO)
        {
            var register = new User()
            {
                Id = Guid.NewGuid().ToString(),
                FName = userDTO.FName,
                LName = userDTO.LName,
                Email = userDTO.Email,
                SSN = userDTO.SSN,
                Address = userDTO.Address,
                PhoneNumber = userDTO.phoneNumber,
                ProfilePic = userDTO.ProfilePic,

            };

        }
    }
}
