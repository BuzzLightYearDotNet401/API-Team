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
    public class ExercisesController : ControllerBase
    {
        private readonly HealthAtHomeAPIDbContext _context;
        private readonly IExerciseManager _exercise;


        public ExercisesController(HealthAtHomeAPIDbContext context, IExerciseManager exercise)
        {
            _context = context;
            _exercise = exercise;
        }

        // GET: api/Exercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exercises>>> GetExercises()
        {
            return await _exercise.GetAllExercises();
        }

        // GET: api/Exercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercises>> GetExercises(int id)
        {
            var exercises = await _context.Exercises.FindAsync(id);

            if (exercises == null)
            {
                return NotFound();
            }

            return exercises;
        }

        // PUT: api/Exercises/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExercises(int id, Exercises exercises)
        {
            if (id != exercises.ID)
            {
                return BadRequest();
            }

            _context.Entry(exercises).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExercisesExists(id))
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

        // POST: api/Exercises
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Exercises>> PostExercises(Exercises exercises)
        {
            _context.Exercises.Add(exercises);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercises", new { id = exercises.ID }, exercises);
        }

        // DELETE: api/Exercises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Exercises>> DeleteExercises(int id)
        {
            var exercises = await _context.Exercises.FindAsync(id);
            if (exercises == null)
            {
                return NotFound();
            }

            _context.Exercises.Remove(exercises);
            await _context.SaveChangesAsync();

            return exercises;
        }

        private bool ExercisesExists(int id)
        {
            return _context.Exercises.Any(e => e.ID == id);
        }
    }
}
