using Domain_Layer.DTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IUserRepo :IBaseRepo<User>
    {
        Task<User> Register(UserDTO userDTO);
        Task<User> GetUser(string userId);
    }
}
