using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using justtest.Models;
using Microsoft.EntityFrameworkCore;

namespace justtest.Controllers
{
    [Route("api/movies")]
    public class ApiMoviesController : ControllerBase
    {
        private readonly ModelContext _context;

        public ApiMoviesController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.Movie.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .SingleOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Movie movie)
        {
            Console.WriteLine(value: $"{movie.ToString()}");
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Details", new { id = movie.ID},movie);
            }
            
            return BadRequest(ModelState);
        }
    }
}