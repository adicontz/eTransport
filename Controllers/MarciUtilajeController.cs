using eTransport.Data;
using eTransport.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTransport.Controllers
{
    public class MarciUtilajeController : Controller
    {
        private readonly IMarciUtilajeServices _service;

        public MarciUtilajeController(IMarciUtilajeServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var AllMarciUtilaje = await _service.GetAllAsync();
            return View(AllMarciUtilaje);
        }
    }
}
