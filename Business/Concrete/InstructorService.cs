using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorService : IInstructorService
    {
        IInstructorDal _dal;

        public InstructorService(IInstructorDal dal)
        {
            _dal = dal;
        }

        public async Task<List<Instructor>> GetInstructors()
        {
            return _dal.GetAll(x => !x.IsDeleted);
        }
    }
}