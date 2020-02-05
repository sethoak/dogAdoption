using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models.Data;

namespace Capstone.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Dogs1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dog>>> GetDog()
        {
            return await _context.Dog.ToListAsync();
        }

        // GET: api/Dogs1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dog>> GetDog(int id)
        {
            var dog = await _context.Dog.FindAsync(id);

            if (dog == null)
            {
                return NotFound();
            }

            return dog;
        }

        // PUT: api/Dogs1/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDog(int id, Dog dog)
        {
            if (id != dog.Id)
            {
                return BadRequest();
            }

            _context.Entry(dog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogExists(id))
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

        // POST: api/Dogs1
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Dog>> PostDog(Dog dog)
        {
            _context.Dog.Add(dog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDog", new { id = dog.Id }, dog);
        }

        // DELETE: api/Dogs1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dog>> DeleteDog(int id)
        {
            var dog = await _context.Dog.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }

            _context.Dog.Remove(dog);
            await _context.SaveChangesAsync();

            return dog;
        }

        private bool DogExists(int id)
        {
            return _context.Dog.Any(e => e.Id == id);
        }
    }
}
