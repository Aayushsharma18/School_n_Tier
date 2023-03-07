using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace School_Buinesslogic.Models
{
    public class Student_BL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int? GradeId { get; set; }
        public int? TeacherId { get; set; }
    }
}