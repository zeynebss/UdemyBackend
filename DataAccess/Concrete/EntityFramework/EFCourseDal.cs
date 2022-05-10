using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCourseDal : EFEntityRepositoryBase<Course, CourseContext>, ICourseDal
    {
        public async Task<List<Course>> GetAllInclude(Expression<Func<Course, bool>>? filters)
        {
            using CourseContext context = new();
            var course = context.Courses
                .Where(x => !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.Insturctor)
                .Include(x => x.CourseSpesification)
                .AsQueryable();

            if (filters != null)
            {
                course = course.Where(filters);
            }
            return await course.ToListAsync();
        }

        public async Task<List<Course>> GetAllPopulars(Expression<Func<Course, bool>>? filters)
        {
            using CourseContext context = new();
            var course = context.Courses
                .Where(x => !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.Insturctor)
                .Include(x => x.CourseSpesification)
                .OrderByDescending(x => x.Raiting)
                .AsQueryable();

            if (filters != null)
            {
                course = course.Where(filters);
            }
            return await course.ToListAsync();
        }

        public async Task<Course> GetById(Expression<Func<Course, bool>>? filters)
        {
            using CourseContext context = new();
            var course = context.Courses
                .Where(x => !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.Insturctor)
                .Include(x => x.CourseSpesification)
                .OrderByDescending(x => x.Raiting)
                .FirstOrDefault(filters);
            return course;
        }
    }
}
