using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class InstructorDTO
    {
        public int ID { get; set; }
        public string FullName { get; set; } = null!;
        public string? Speciality { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
