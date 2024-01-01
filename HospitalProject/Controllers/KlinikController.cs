using HospitalProject.Data;
using HospitalProject.Data.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace HospitalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlinikController : Controller
    {
        ApplicationDbContext _context;

        public KlinikController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("guncel")]
        public IActionResult Guncel()
        {
            return View();
        }

        [HttpGet("hata")]
        public IActionResult Hata()
        {
            return View();
        }

        [HttpGet("kliniks")]
        public IActionResult GetKlinik()
        {
            var result=_context.Kliniks.ToList();
            return View(result);
        }

        [HttpPost("ekle")]
        public async Task<IActionResult> KlinikEkle([FromForm] Klinik k)
        {
            var added = _context.Entry(k);
            added.State = EntityState.Added;
            await _context.SaveChangesAsync();
            return RedirectToAction("GetKlinik");

        }


        [HttpPut("guncelle")]
        public async Task<ActionResult> KlinikGuncelle(Klinik k, int? id)
        {
            var result = _context.Kliniks.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return RedirectToAction("Hata");
            }
            var updated = _context.Entry(k);
            updated.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction("GetKliink");
        }


    }
}
