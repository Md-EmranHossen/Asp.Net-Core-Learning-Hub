using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitiesManager.API.Data;
using CitiesManager.API.Models;

namespace CitiesManager.API.Controllers
{
    
    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            if(_context.Cities == null)
            {
                return NotFound();
            }
            return await _context.Cities.OrderBy(temp=>temp.Name).ToListAsync();
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(Guid id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(temp => temp.CityID == id);

            if (city == null)
            {
                return Problem(detail: "Invalid CityID", statusCode: 400, title: "City Search");

            }

            return city ;
        }

     
        [HttpPut("{cityID}")]
        public async Task<IActionResult> PutCity(Guid cityID,[Bind(nameof(City.CityID),nameof(City.Name))] City city)
        {
            if (cityID != city.CityID)
            {
                return BadRequest();
            }

            //_context.Entry(city).State = EntityState.Modified;
            var existingCity = await _context.Cities.FindAsync(cityID);

            if(existingCity == null)
            {
                return Problem(detail: "Invalid CityID", statusCode: 400, title: "City Search");

            }

            existingCity.Name = city.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(cityID))
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

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<City>> PostCity([Bind(nameof(city.CityID),nameof(City.Name))]   City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.CityID }, city);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(Guid id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(Guid id)
        {
            return _context.Cities.Any(e => e.CityID == id);
        }
    }
}
