using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_DataAccess.Models;

namespace School_DataAccess.Interfaces
{
    public interface ITeacherActionManager
    {
        IList<Teacher> GetTeachers();
        IQueryable<Teacher> GetTeacher(int id);
        Teacher AddTeacher(Teacher teacher);
        Teacher UpdateTeacher(Teacher teacher);
        int DeleteTeacher(int id);

    }
}