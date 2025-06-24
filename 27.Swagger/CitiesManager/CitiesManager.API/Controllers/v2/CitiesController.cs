using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitiesManager.API.Data;
using CitiesManager.API.Models;

namespace CitiesManager.API.Controllers.v2
{
    [ApiVersion("2.0")]

    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        /// <summary>
        /// To get get list of cities (Only Citi name) form
        ///  'cities' table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/xml")]
        public async Task<ActionResult<IEnumerable<string?>>> GetCities()
        {
            if(_context.Cities == null)
            {
                return NotFound();
            }
            return await _context.Cities.OrderBy(temp=>temp.Name)
                .OrderBy(temp => temp.Name)
                .Select(temp => temp.Name)
                .ToListAsync();
        }
      
    }
}
