using Microsoft.AspNetCore.Identity;

namespace HospitalProject.Models
{
    public class User:IdentityUser
    {
        public int Id { get; set; }

        public string Email { get; set; }

        //public List<Randevu>? Randevus { get; set; }


    }
}
