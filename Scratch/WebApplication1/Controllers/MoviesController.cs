using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMvc.Data;

namespace WebMvc.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;
        public MoviesController(MvcMovieContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        public async Task<IActionResult>  Index()
        {
            var list = await _context.Movies.ToListAsync();
            return View( list);
        }
        public  IActionResult Create()
        {
            return View();
        }
    }
}
