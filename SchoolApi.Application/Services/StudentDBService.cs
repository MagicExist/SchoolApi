using SchoolApi.Application.DTOs;
using SchoolApi.Domain.Entities;
using SchoolApi.Domain.Repository;

namespace SchoolApi.Application.Services
{
    public sealed class StudentDBService
    {
        private readonly IStudentDBRepository _studentDBRepository;
        public StudentDBService(IStudentDBRepository studentDBRepository) 
        {
            _studentDBRepository = studentDBRepository;
        }

        public async Task<IEnumerable<StudentDto>> ReadAsync()
        {
            List<StudentDto> studentDtoList = new List<StudentDto>();
            IEnumerable<Student> studentsList = await _studentDBRepository.GetAllStudentsAsync();
            foreach (Student student in studentsList) 
            {
                StudentDto studentDto = new StudentDto() 
                {
                    Id = student.Id,
                    Name = student.Name,
                    Age = student.Age,
                };
                studentDtoList.Add(studentDto);
            }
            return studentDtoList;
        }

    }
}
