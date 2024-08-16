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

        public async Task<IEnumerable<Student>> ReadAsync()
        {
            IEnumerable<Student> studentsList = await _studentDBRepository.GetAllStudentsAsync();
            return studentsList;
        }

    }
}
