using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalProject.Models
{
    public class WorkingHour
    {
        public int Id { get; set; }
        
        public int DoctorId { get; set; }
        public int DayOfWeek { get; set; }
        
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        
        public Doctor Doctor { get; set; }
        
        public List<Randevu> Randevus { get; set; }
    }
}