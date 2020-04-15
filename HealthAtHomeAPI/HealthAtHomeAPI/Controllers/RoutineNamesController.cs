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
    public class RoutineNamesController : ControllerBase
    {
        private readonly IRoutineNameManager _routineName;
        private readonly IExerciseManager _exercise;

        public RoutineNamesController(IRoutineNameManager routineName, IExerciseManager exercise)
        {
            _routineName = routineName;
            _exercise = exercise;
        }

        // GET: api/RoutineNames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoutineNamesDTO>>> GetRoutineNames()
        {
            return await _routineName.GetAllRoutineNames();
        }

        // GET: api/RoutineNames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoutineNamesDTO>> GetRoutineName(int id)
        {
            var routineName = await _routineName.GetRoutineById(id);

            if (routineName == null)
            {
                return NotFound();
            }

            return routineName;
        }

        //[HttpGet("{routineId}")]
        //public async Task<ActionResult<IEnumerable<ExerciseDTO>>> GetExercisesForRoutine(int routineId)
        //{
        //    return await _routineName.GetExercisesForRoutines(routineId);
        //}

        //    var exerciseList = await _context.RoutineNames.Where(x => x.RoutineNameId == routineId).ToListAsync();

        //    List<ExerciseDTO> exercisesInRoutine = new List<ExerciseDTO>();

        //    foreach (var item in exerciseList)
        //    {
        //        var exercise = await _exercise.GetExercisesById(item.RoutineNameId);
        //        exercisesInRoutine.Add(exercise);
        //    }
        //    return exercisesInRoutine;
        //}
        //// PUT: api/RoutineNames/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutRoutineName(int id, RoutineName routineName)
        //{
        //    if (id != routineName.RoutineNameId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(routineName).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!RoutineNameExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/RoutineNames
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<RoutineName>> PostRoutineName(RoutineName routineName)
        //{
        //    _context.RoutineNames.Add(routineName);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetRoutineName", new { id = routineName.RoutineNameId }, routineName);
        //}

        //// DELETE: api/RoutineNames/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<RoutineName>> DeleteRoutineName(int id)
        //{
        //    var routineName = await _context.RoutineNames.FindAsync(id);
        //    if (routineName == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.RoutineNames.Remove(routineName);
        //    await _context.SaveChangesAsync();

        //    return routineName;
        //}

        //private bool RoutineNameExists(int id)
        //{
        //    return _context.RoutineNames.Any(e => e.RoutineNameId == id);
        //}
    }
}
