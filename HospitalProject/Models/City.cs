using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace HospitalProject.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        

        public List<County> Counties { get; set; }
    }
}
