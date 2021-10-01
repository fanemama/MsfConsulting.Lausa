﻿using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Model;
using System;

namespace MsfConsulting.Lausa.Domain.Service
{
    public class StudentService : DomainService, IStudentService
    {
        public StudentService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }

        public void UpdatePersonalInfo(StudentPersonalInfo studentPersonalInfo)
        {
            throw new NotImplementedException();
        }

        public void Enroll(int id, Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public void Register(Student student)
        {
            throw new NotImplementedException();
        }

        public void Unenroll(int id, Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public void Unregister(int id)
        {
            throw new NotImplementedException();
        }
    }
}
