﻿using MsfConsulting.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Business.Service
{
    public interface IEnrollmentService
    {
        void Transfer(long id, Course course);
    }
}