using HospitalProject.Data;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("kliniks")]
        public IActionResult GetKlinik()
        {
            var result=_context.Kliniks.ToList();
            return View(result);
        }
    }
}
