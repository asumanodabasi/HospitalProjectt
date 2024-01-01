using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalProject.Models
{
    public class Doctor
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        
        public int KlinikId { get; set; }
        
        public Klinik? Klinik { get; set; }

        public int WorkId { get; set; }
        
        public int HospitalId { get; set; }
        public Hospital? Hospital { get; set; }
        public List<Randevu>? Randevus { get; set; }
        
        public List<WorkingHour>? Hours { get; set; }

    }
}
