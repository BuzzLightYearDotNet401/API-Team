using HealthAtHomeAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IUserManager
    {
        //Create
        Task<UserDTO> CreateUser(User user);
        //Read
        Task<UserDTO> GetUserById(int userId);
        //Delete
        Task DeleteUser(int userId);
    }
}
