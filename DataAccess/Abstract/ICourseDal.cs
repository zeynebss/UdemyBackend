using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal:IEntityRepository<Course>
    {
        Task<List<Course>> GetAllInclude(Expression<Func<Course, bool>>? filters);
        Task<List<Course>> GetAllPopulars(Expression<Func<Course, bool>>? filters);
        Task<Course> GetById(Expression<Func<Course, bool>>? filters);
    }
}
