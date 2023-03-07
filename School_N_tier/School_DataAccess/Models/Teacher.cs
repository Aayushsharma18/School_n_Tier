using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Modles.Models;

#nullable disable
namespace School_DataAccess.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public long Phone { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}