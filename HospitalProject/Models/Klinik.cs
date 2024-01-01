using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalProject.Models
{
    public class Klinik
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int HospitalId { get; set; }

        public int DoctorId { get; set; }
        
        [NotMapped]
        public List<HospitalKlinik> HospitalKliniks { get; set; }
        [NotMapped]
        public List<Hospital> Hospitals { get; set; }
        [NotMapped]
        public List<Doctor> Doctors { get; set; }
    }
}
