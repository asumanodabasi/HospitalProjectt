using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int IlId { get; set; }
        public int CountyId { get; set; }
        public int HastaneId { get; set; }
        public int KlinikId { get; set; }
        
        public string? UserId { get; set; }
        public int WorkHourId { get; set; }

        
      //  public User? User { get; set; }
        public Doctor? Doctor {  get; set; }
        
    }
}
