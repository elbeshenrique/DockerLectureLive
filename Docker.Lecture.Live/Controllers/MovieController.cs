using System.Collections.Generic;
using System.Linq;
using Docker.Lecture.Live.Data;
using Microsoft.AspNetCore.Mvc;
using static Docker.Lecture.Live.Data.AppDbContext;

namespace Docker.Lecture.Live.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class MovieController {
        private AppDbContext _context;

        public MovieController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Movie> Get() {
            var test = "test";
            test.ToString();
            return _context.Movies.Take(3);
        }
    }
}