using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Models
{
    public class HospitalKlinik
    {
       
     
        public Hospital Hospital { get; set; }

        public Klinik Klinik { get; set; }
        public int HospitalsId { get; set; }
        public int KliniksId { get; set; }
    }
}
