using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_DataAccess.Models;
using School_Services.Models;

namespace School_Services.Interface
{
    public interface ITeacherServiceHandler
    {
        IList<Teacher_DTO> GetTeachers();
        Teacher_DTO GetTeacher(int id);
        Teacher_DTO AddTeacher(Teacher teacher);
        Teacher_DTO UpdateTeacher(Teacher teacher);
        int DeletTeacher(int id);
    }
}