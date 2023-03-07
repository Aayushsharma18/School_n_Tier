using System;
using System.Collections.Generic;
using School_DataAccess.Models;

#nullable disable
namespace School_Modles.Models
{
    public partial class Grade
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Section { get; set; }
        public virtual ICollection<Student> Students { get; } = new List<Student>();
    }
}
