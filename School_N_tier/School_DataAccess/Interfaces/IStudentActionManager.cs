using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Modles.Models;

namespace School_DataAccess.Interfaces
{
    public interface IStudentActionManager
    {
        IList<Student> RetrieveStudents();
        IQueryable<Student> SingleStudent(int id);
        Task<Student> AddStudent(Student student);
        Student UpdateStudent(Student student);
        int DeleteStudent(int id);
        IQueryable<Student> GetTeacherAndGrade(int id);
    }
}