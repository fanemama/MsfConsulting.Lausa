﻿using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class UnenrollCommand : IRequest
    {
        public long Id { get; set; }
        public string Comment { get; set; }
    }
}