
using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET: api/<CourseController>
        ICourseService _service;
        private readonly IMapper _mapper;
        public CourseController(ICourseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CourseDTO>> Get()
        {
            var courses = await _service.GetCourses();
            var _mapperCourses = _mapper.Map<List<Course>, List<CourseDTO>>(courses);
            return _mapperCourses;
        }
        [HttpGet("populars")]
        public async Task<IEnumerable<CourseDTO>> GetPopulars()
        {
            var courses = await _service.GetPopulars();
            var _mapperCourses = _mapper.Map<List<Course>, List<CourseDTO>>(courses);
            return _mapperCourses;
        }
        [HttpGet("discount")]
        public async Task<IEnumerable<CourseDTO>> GetAllDiscount()
        {
            var courses = await _service.GetAllDiscount();
            var _mapperCourses = _mapper.Map<List<Course>, List<CourseDTO>>(courses);
            return _mapperCourses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<CourseDTO> Get(int? id)
        {
            var course = await _service.GetById(id);
            var _mapperCourses = _mapper.Map<Course, CourseDTO>(course);
            return _mapperCourses;
        }
        [HttpGet("category/{categoryId}")]
        public async Task<List<CourseDTO>> GetCourseByCategory(int? categoryId)
        {
            var course = await _service.GetCoursesByCategory(categoryId);
            var _mapperCourses = _mapper.Map<List<Course>, List<CourseDTO>>(course);
            return _mapperCourses;
        }
        [HttpGet("instructor/{instructorId}")]
        public async Task<List<CourseDTO>> GetCourseByInstructor(int? instructorId)
        {
            var course = await _service.GetCoursesByInstructor(instructorId);
            var _mapperCourses = _mapper.Map<List<Course>, List<CourseDTO>>(course);
            return _mapperCourses;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
