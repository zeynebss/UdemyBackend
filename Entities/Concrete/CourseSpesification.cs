using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CourseSpesification:IEntity
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
