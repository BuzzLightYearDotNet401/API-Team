using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IUserManager
    {
        //Create
        Task<User> CreateUser(User user);
        //Read
        Task<User> GetUserById(int userId);
        //Delete
        Task DeleteUser(int userId);
    }
}
