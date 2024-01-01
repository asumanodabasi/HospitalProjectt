using HospitalProject.Data;
using HospitalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {

        private ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("RandevuEkle");
        }

        [HttpGet("Randevu")]
        public async Task<ActionResult> Randevu()
        {
            var hospitals = new RandevuModel
            {
                Cities = await _context.Cities.Include(c => c.Counties).ThenInclude(h => h.Hospitals).ThenInclude(x => x.Kliniks).ToListAsync()
            };

            return View("Randevu", hospitals);

        }

        public IActionResult ExistRandevu()
        {
            return RedirectToAction("Randevu");
        }

        [HttpGet("GetHours/{doktorId}")]
        public IActionResult GetHours(int doktorId)
        {
            var hour = _context.WorkHours.Where(w => w.DoctorId == doktorId);
            return Json(hour);
        }

        [HttpGet("GetKliniks/{hastaneId}")]
        public IActionResult GetKlinik(int hastaneId)
        {
            var klinikler = _context.Kliniks.Where(x => x.HospitalId == hastaneId).ToList();

            return Json(klinikler);
        }

        [HttpGet("GetDoctors/{klinikId}")]
        public IActionResult GetDoctors(int klinikId)
        {
            var doctors = _context.Doctors.Where(k => k.KlinikId == klinikId).ToList();
            return Json(doctors);
        }

        [HttpGet("GetIlceler/{ilId}")]
        public IActionResult GetIlceler(int ilId)
        {
            var ilceler = _context.Counties.Where(c => c.CityId == ilId).ToList();
            return Json(ilceler);
        }

        [HttpGet("GetHastaneler/{ilceId}")]
        public IActionResult GetHastaneler(int ilceId)
        {
            var hastaneler = _context.Hospitals.Where(h => h.CountyId == ilceId).ToList();
            return Json(hastaneler);
        }

        [HttpPost("RandevuEkle")]
        public async Task<ActionResult> RandevuEkle([FromForm] Randevu randevu)
        {
            var result = _context.Randevus.Where(x => x.Id == randevu.Id).ToList();
            
            if (result.Count==0)
            {
                var ran = new Randevu
                {

                    Id = randevu.Id,
                    IlId = randevu.IlId,
                    CountyId = randevu.CountyId,
                    HastaneId = randevu.HastaneId,
                    KlinikId = randevu.KlinikId,
                    DoktorId = randevu.DoktorId,
                    WorkHourId = randevu.WorkHourId
                };


                _context.Randevus.Add(randevu);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Randevu başarıyla kaydedildi.";
                return Json(ran);
            }

            else
            {
                TempData["ErrorMessage"] = "Randevu alamazsınız.";
                return RedirectToAction("ExistRandevu");
            }
        }

     
        public IActionResult RandevuVer([FromForm] Randevu r)
        {

            return Json(r);
        }
    }
}
