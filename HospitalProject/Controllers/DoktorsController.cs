using HospitalProject.Data;
using HospitalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HospitalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorsController : Controller
    {
        ApplicationDbContext _context;

        public DoktorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            return View();
        }
        [HttpGet("GetDoctors")]
        public IActionResult DoktorGetir()
        {
            var result=_context.Doctors.ToList();
            return View(result);
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<IActionResult> DoktorAdd([FromForm]Doctor doctor) 
        {
                var added = _context.Entry(doctor);
                added.State = EntityState.Added;
               await _context.SaveChangesAsync();

            return RedirectToAction("DoktorGetir");
        
        }
    }
}
