using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public decimal? Raiting { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Instructor Insturctor { get; set; }
        public List<CourseSpesification>? CourseSpesification { get; set; }
        

    }
}
