using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        public string? DoktorId { get; set; }
        public string? IlId { get; set; }
        public string? CountyId { get; set; }
        public string? HastaneId { get; set; }
        public string? KlinikId { get; set; }
        
        public string? UserId { get; set; }
        public string? WorkHourId { get; set; }

        
      //  public User? User { get; set; }
        public Doctor? Doctor {  get; set; }
        
    }
}
