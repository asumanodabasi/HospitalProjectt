using HospitalProject.Data;
using HospitalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HospitalProject.Controllers
{
    public class UsersController : Controller
    {
        
        private ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsersController
        public async Task<ActionResult> IndexAsync()
        {
            HttpClient httpClient = new HttpClient();
            List<RandevuModel> hospital = new List<RandevuModel>();
            var response = await httpClient.GetAsync("https://localhost:7124/api/Hospitals");
            var responesetext = await response.Content.ReadAsStringAsync();
            hospital = JsonConvert.DeserializeObject<List<RandevuModel>>(responesetext);
            return View(hospital);
   
        }

        
        public IActionResult GetUser()
        {
            var result = _context.Users.ToList();
            return View(result);
        }

        
        public IActionResult AddUser(User user)
        {
            _context.Users.Add(user);
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
