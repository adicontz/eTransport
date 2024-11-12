using eTransport.Data;
using eTransport.Data.Services;
using eTransport.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTransport.Controllers
{
    public class SoferiController : Controller
    {
        private readonly ISoferiServices _service;

        public SoferiController(ISoferiServices service)
        {
            _service = service;
        }

              public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Soferi/Adauga
        
        public IActionResult Adauga()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Adauga([Bind("Id,NumeComplet,ImagineUrl,Biografie")] Sofer sofer)
        {
            if (!ModelState.IsValid)
            {
                return View(sofer);
            }
            await _service.AddAsync(sofer);
            return RedirectToAction(nameof(Index));
        }

        // Get: Soferi/Detalii/1
        
        public async Task<IActionResult> Detalii(int id)
        {
            var soferDetails = await _service.GetByIdAsync(id);

            if (soferDetails == null) return View("NotFound");
            return View(soferDetails);
        }

        // Get: Soferi/Editeaza/1
        
        public async Task<IActionResult> Editeaza(int id)
        {
            var soferDetails = await _service.GetByIdAsync(id);
            if (soferDetails == null) return View("NotFound");
            return View(soferDetails);
        }

        [HttpPost]
        
        public async Task<IActionResult> Edit(int id, Sofer sofer)
        {
            if (id != sofer.Id)
            {
                return BadRequest("ID-ul șoferului nu se potrivește.");
            }

            if (!ModelState.IsValid)
            {
                return View(sofer);
            }

            await _service.UpdateAsync(id, sofer);
            return RedirectToAction(nameof(Index));
        }

        // Get: Soferi/Sterge/1
        
        public async Task<IActionResult> Sterge(int id)
        {
            var soferDetails = await _service.GetByIdAsync(id);
            if (soferDetails == null) return View("NotFound");
            return View(soferDetails);
        }

        [HttpPost, ActionName("Sterge")]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var soferDetails = await _service.GetByIdAsync(id);
            if (soferDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
