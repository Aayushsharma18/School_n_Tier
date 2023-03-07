using System;
using System.Collections.Generic;
using School_DataAccess.Models;

#nullable disable
namespace School_Modles.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string? Address { get; set; }
        public string? Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int? GradeId { get; set; }
        public int? TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Grade? Grade { get; set; }
    }
}
