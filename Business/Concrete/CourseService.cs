using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class CourseService : ICourseService
    {
        private readonly ICourseDal _dal;
        public CourseService(ICourseDal dal)
        {
            _dal = dal;
        }

        public async Task<List<Course>> GetAllDiscount()
        {
            var courses = await _dal.GetAllInclude(x => x.Discount != 0 && x.Discount != null);
            return courses;
        }

        public async Task<Course> GetById(int? id)
        {
            return await _dal.GetById(x => x.ID == id);
        }

        public async Task<List<Course>> GetCourses()
        {
            var courses = await _dal.GetAllInclude(x => !x.IsDeleted);
            return courses;
        }

        public async Task<List<Course>> GetCoursesByCategory(int? categoryId)
        {
            var courses = await _dal.GetAllInclude(x => x.CategoryId == categoryId);
            return courses;
        }

        public async Task<List<Course>> GetCoursesByInstructor(int? InstructorId)
        {
            var courses = await _dal.GetAllInclude(x => x.InstructorId == InstructorId);
            return courses;
        }

        public async Task<List<Course>> GetPopulars()
        {
            var courses = await _dal.GetAllPopulars(x => !x.IsDeleted);
            return courses;
        }
    }
}
