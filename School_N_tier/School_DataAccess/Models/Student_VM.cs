using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_DataAccess.Models
{
    public class Student_VM
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        // public string? Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int? GradeId { get; set; }
        public int? TeacherId { get; set; }
    }
}