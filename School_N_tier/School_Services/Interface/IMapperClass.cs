using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Buinesslogic.Models;
using School_DataAccess.Models;
using School_Modles.Models;
using School_Services.Models;

namespace School_Services.Interface
{
    public interface IMapperClass
    {
        Student_BL ConvertStudentEntityToBL(Student student);
        Student_DTO ConvertStudentBLToDTO(Student_BL student_BL);

        Grade_BL ConvertGradeEntityToBL(Grade grade);
        Grade_DTO ConvertGradeBLToDTO(Grade_BL grade_BL);

        Teacher_BL ConvertTeacherEntityToBL(Teacher teacher);
        Teacher_DTO ConvertTeacherBLToDTO(Teacher_BL teacher_BL);

    }
}