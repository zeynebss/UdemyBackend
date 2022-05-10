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
    public class InstructorController : ControllerBase
    {
        IInstructorService _service;

        public InstructorController(IInstructorService service)
        {
            _service = service;
        }

        private readonly IMapper _mapper;

       

        // GET: api/<InstructorController>
        [HttpGet]
        public async Task<IEnumerable<InstructorDTO>> Get()
        {
            var instructor = await _service.GetInstructors();
            var _mapperInstructor = _mapper.Map<List<Instructor>, List<InstructorDTO>>(instructor);
            return _mapperInstructor;
        }

        // GET api/<InstructorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InstructorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InstructorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InstructorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
