using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Web_API.Models;

namespace Movie_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Filmek")]

        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            if (_context == null)
            {
                return NotFound();
            }
            return await _context.Movies.ToListAsync();
        }

        
    }
}