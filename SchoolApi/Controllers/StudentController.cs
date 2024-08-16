using Microsoft.AspNetCore.Mvc;
using SchoolApi.Application.Services;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDBService _studentDBService;
        public StudentController(StudentDBService studentDBService) 
        {
            _studentDBService = studentDBService;
        }


        [HttpGet]
        public async Task<IEnumerable<Student>> GetAsync()
        {
            return await _studentDBService.ReadAsync();
        }
    }
}
