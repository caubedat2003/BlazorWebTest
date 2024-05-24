﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class PatientRequest
    {
        public Guid PatientId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Target { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nation { get; set;}
        public int Age { get; set;}
        public string PhoneNumber { get; set;}
        public string Address { get; set;}
    }
}