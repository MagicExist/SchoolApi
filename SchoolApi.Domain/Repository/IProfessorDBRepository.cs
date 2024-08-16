﻿using SchoolApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApi.Domain.Repository
{
    public interface IProfessorDBRepository
    {
        Task<IEnumerable<Professor>> GetAllProfessorsAsync();
    }
}