using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
 public interface ICourseService
    {
        Task<List<Course>> GetCourses();
        Task<List<Course>> GetPopulars();
        Task<List<Course>> GetAllDiscount();
        Task<Course> GetById(int? id);
        Task<List<Course>> GetCoursesByCategory(int? categoryId);
        Task<List<Course>> GetCoursesByInstructor(int? InstructorId);
    }
}
