using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthAtHomeAPI.Data;
using HealthAtHomeAPI.Models;
using HealthAtHomeAPI.Models.Interfaces;
using HealthAtHomeAPI.Models.DTO;

namespace HealthAtHomeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Bringing in the database and the IUserManager interface
        /// </summary>
        private readonly HealthAtHomeAPIDbContext _context;
        private readonly IUserManager _user;

        /// <summary>
        /// Injecting the database and the IUserManager interface
        /// </summary>
        /// <param name="context">variable assigned to the db</param>
        /// <param name="user">variable assigned to the IUserManager interface</param>
        public UsersController(HealthAtHomeAPIDbContext context, IUserManager user)
        {
            _context = context;
            _user = user;
        }

        /// <summary>
        /// GET route to return all users
        /// </summary>
        /// <returns>Users</returns>
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// GET route to return user by Id
        /// </summary>
        /// <param name="id">int Id</param>
        /// <returns>User corresponding to Id</returns>
        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
            var user = await _user.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// PUT route to update user based on Id
        /// </summary>
        /// <param name="id">int Id</param>
        /// <param name="user">string User</param>
        /// <returns>Bad request if not found; no content if successful</returns>
        // PUT: api/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// POST route to create a user
        /// </summary>
        /// <param name="user">string user</param>
        /// <returns>user</returns>
        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<UserDTO>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _user.CreateUser(user);

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        /// <summary>
        /// DELETE route to delete user by Id
        /// </summary>
        /// <param name="id">int Id</param>
        /// <returns>No content</returns>
        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDTO>> DeleteUser(int id)
        {
            await _user.DeleteUser(id);
            return NoContent();

        }

        /// <summary>
        /// Boolean method to see if user exists based on Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>True or False</returns>
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
