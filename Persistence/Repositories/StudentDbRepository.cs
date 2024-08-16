using Microsoft.EntityFrameworkCore;
using Persistence.DataBase;
using SchoolApi.Domain.Entities;
using SchoolApi.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class StudentDbRepository : IStudentDBRepository
    {
        private readonly SchoolDbContext _dbContext;
        public StudentDbRepository(SchoolDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
    }
}
