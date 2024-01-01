using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public int CountyId { get; set; }
        public int KlinikId { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }
        public List<HospitalKlinik> HospitalKliniks { get; set; }
        
        public County County { get; set; }
        public List<Klinik> Kliniks { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<City> City { get; set; }
    }
}
