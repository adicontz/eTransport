using eTransport.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTransport.Controllers
{
    public class LocatiiController : Controller
    {
        private readonly AppDbContext _context;

        public LocatiiController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllLocatii = await _context.Locatii.ToListAsync();
            return View(AllLocatii);
        }
    }
}