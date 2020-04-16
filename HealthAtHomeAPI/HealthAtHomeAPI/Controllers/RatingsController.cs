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

namespace HealthAtHomeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        /// <summary>
        /// Bringing in the database and IRatingManager interface
        /// </summary>
        private readonly HealthAtHomeAPIDbContext _context;
        private readonly IRatingManager _rating;

        /// <summary>
        /// Injecting the database and IRatingManager interface
        /// </summary>
        /// <param name="context"></param>
        /// <param name="rating"></param>
        public RatingsController(HealthAtHomeAPIDbContext context, IRatingManager rating)
        {
            _context = context;
            _rating = rating;
        }

        /// <summary>
        /// GET route to return a list of ratings
        /// </summary>
        /// <returns>a list of ratings</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        {
            return await _context.Ratings.ToListAsync();
        }

        /// <summary>
        /// GET route to get rating by Id
        /// </summary>
        /// <param name="id">int Id</param>
        /// <returns>rating corresponding to Id</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> GetRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            return rating;
        }

        /// <summary>
        /// PUT route to update rating by Id
        /// </summary>
        /// <param name="id">int Id</param>
        /// <param name="rating">enum Rating</param>
        /// <returns>BadRequest if not found; Nothing if update is successful.</returns>
        // PUT: api/Ratings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating rating) //Update
        {
            if (id != rating.UserId)
            {
                return BadRequest();
            }

            await _rating.UpdateRating(id, rating);

            return NoContent();
        }

        /// <summary>
        /// POST route to get a routine connected to their UserId
        /// </summary>
        /// <param name="rating">enum Rating</param>
        /// <returns>routine</returns>
        // POST: api/Ratings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RatingExists(rating.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRating", new { id = rating.UserId }, rating);
        }

        /// <summary>
        /// DELETE route to delete a rating 
        /// </summary>
        /// <param name="id">rating by Id</param>
        /// <returns>returns NotFound if not found, otherwise returns rating</returns>
        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rating>> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return rating;
        }

        /// <summary>
        /// Boolean method to see if rating exists
        /// </summary>
        /// <param name="id">int Id</param>
        /// <returns>True or False</returns>
        private bool RatingExists(int id)
        {
            return _context.Ratings.Any(e => e.UserId == id);
        }
    }
}
