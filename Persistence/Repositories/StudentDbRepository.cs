using Microsoft.EntityFrameworkCore;
using Persistence.DataBase;
using SchoolApi.Domain.Entities;
using SchoolApi.Domain.Repository;

namespace Persistence.Repositories
{
    public class StudentDBRepository : IStudentDBRepository
    {
        private readonly SchoolDbContext _dbContext;
        public StudentDBRepository(SchoolDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
    }
}
