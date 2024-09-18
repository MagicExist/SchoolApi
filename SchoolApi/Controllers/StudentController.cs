using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SchoolApi.Application.DTOs;
using SchoolApi.Application.Services;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDBService _studentDBService;
        private readonly IMemoryCache _memoryCache;
        public StudentController(StudentDBService studentDBService,IMemoryCache memoryCache) 
        {
            _studentDBService = studentDBService;
            _memoryCache = memoryCache;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            if(!_memoryCache.TryGetValue("Students",out IEnumerable<StudentDto> studentList))
            {
                studentList = await _studentDBService.ReadAsync();
                _memoryCache.Set("Students",studentList,TimeSpan.FromMinutes(1));
            }
            else
            {
                Console.WriteLine("Estoy almacenado en cache");
                return Ok(new {message = "From Cache",list = studentList});
            }
            if (studentList == null)
            {
                return NotFound();
            }
            return Ok(studentList);
        }
    }
}
