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

        /// <summary>
        /// allows us to create a user and save the changes
        /// </summary>
        /// <param name="user">the user</param>
        /// <returns>the created user</returns>
        public async Task<UserDTO> CreateUser(User user)
        {
            var userDTO = UserDTO(user);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return userDTO;
        }

        /// <summary>
        /// gets the user specifically by id
        /// </summary>
        /// <param name="userId">the user's id</param>
        /// <returns>The user that was requested</returns>
        public async Task<UserDTO> GetUserById(int userId)
        {
            User user = await _context.Users.FindAsync(userId);
            return UserDTO(user);
        }

        /// <summary>
        /// Deletes a user. It finds that is, removes it, then saves the changes
        /// </summary>
        /// <param name="userId">the user's id</param>
        public async Task DeleteUser(int userId)
        {
            User user = await _context.Users.FindAsync(userId);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();            
        }

        /// <summary>
        /// Allows us to normalize the user data
        /// </summary>
        /// <param name="user">the User Model</param>
        /// <returns>Returns as a DTO</returns>
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
