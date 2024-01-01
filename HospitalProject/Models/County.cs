using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public string Name { get; set; }

        public City City { get; set; }

        public List<Hospital> Hospitals { get; set; }
    }
}
