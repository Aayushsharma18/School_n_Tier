using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Modles.Models;
using School_Services.Models;

namespace School_Services.Interface
{
    public interface IStudentServiceHandler
    {
        IList<Student_DTO> RetriveStudents();
        Student_DTO SingleResult(int id);
        Task<Student_DTO> AddStudent(Student student);
        Student_DTO UpdateStudent(Student student);
        int DeleteStudent(int id);
        Student_DTO GetTecherAndGradeOfStudent(int id);

    }
}