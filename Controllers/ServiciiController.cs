using eTransport.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTransport.Controllers
{
    public class ServiciiController : Controller
    {
        private readonly AppDbContext _context;

        public ServiciiController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllServicii = await _context.Servicii.Include(n => n.Locatie).ToListAsync();
            return View(AllServicii);
        }
    }
}