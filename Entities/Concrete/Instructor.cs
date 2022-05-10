using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Instructor:IEntity
    {
        public int ID { get; set; }
        public string FullName { get; set; } = null!;
        public string? Speciality { get; set; }  
        public string? PhotoUrl { get; set; }    
        public bool IsDeleted { get; set; } 

    }
}
