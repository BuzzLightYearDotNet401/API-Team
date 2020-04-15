using HealthAtHomeAPI.Data;
using HealthAtHomeAPI.Models.DTO;
using HealthAtHomeAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Services
{
    public class UserService : IUserManager
    {
        /// <summary>
        /// Injecting our database into our user service
        /// </summary>
        private HealthAtHomeAPIDbContext _context;

        public UserService(HealthAtHomeAPIDbContext context)
        {
            _context = context;
        }

        // allows us to create a user and save the changes
        public async Task<UserDTO> CreateUser(User user)
        {
            var userDTO = UserDTO(user);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return userDTO;
        }

        // Read - gets the user specifically by id
        public async Task<UserDTO> GetUserById(int userId)
        {
            User user = await _context.Users.FindAsync(userId);
            return UserDTO(user);
        }

        /// <summary>
        /// Deletes a user. It uses the GetUserById method from above and removes that user. Then saves the changes
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task DeleteUser(int userId)
        {
            User user = await _context.Users.FindAsync(userId);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();            
        }

        private UserDTO UserDTO(User user)
        {
            UserDTO uDto = new UserDTO()
            {
                UserId = user.UserId,
                Name = user.Name
            };
            return uDto;
        }


    }
}
