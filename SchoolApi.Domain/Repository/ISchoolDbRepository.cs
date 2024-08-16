using SchoolApi.CoreLayer.DomainLayer.Domain.SchoolDbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApi.CoreLayer.DomainLayer.Repository
{
    internal interface ISchoolDbRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<IEnumerable<Professor>> GetProfessorsAsync();
    }
}
