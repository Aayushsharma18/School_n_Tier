using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Buinesslogic.Models;
using School_DataAccess.Models;
using School_Modles.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_Services.Repository
{
    public class ConvertEntityToDTO : IMapperClass
    {
        public Grade_DTO ConvertGradeBLToDTO(Grade_BL grade_BL)
        {
            Grade_DTO grade_DTO = new Grade_DTO()
            {
                Id = grade_BL.Id,
                Name = grade_BL.Name,
                Section = grade_BL.Section
            };
            return grade_DTO;
        }

        public Grade_BL ConvertGradeEntityToBL(Grade grade)
        {
            Grade_BL grade_BL = new Grade_BL()
            {
                Id = grade.Id,
                Name = grade.Name,
                Section = grade.Section
            };
            return grade_BL;
        }

        public Teacher_DTO ConvertTeacherBLToDTO(Teacher_BL teacher_BL)
        {
            Teacher_DTO teacher_DTO = new Teacher_DTO()
            {
                Id = teacher_BL.Id,
                Name = teacher_BL.Name,
                DateOfBirth = teacher_BL.DateOfBirth,
                Phone = teacher_BL.Phone
            };
            return teacher_DTO;
        }

        public Teacher_BL ConvertTeacherEntityToBL(Teacher teacher)
        {
            Teacher_BL teacher_BL = new Teacher_BL()
            {
                Id = teacher.Id,
                Name = teacher.Name,
                DateOfBirth = teacher.DateOfBirth,
                Phone = teacher.Phone
            };
            return teacher_BL;
        }

        public Student_DTO ConvertStudentBLToDTO(Student_BL student_BL)
        {
            Student_DTO _student_DTO = new Student_DTO()
            {
                Id = student_BL.Id,
                Name = student_BL.Name,
                DateOfBirth = student_BL.DateOfBirth,
                Address = student_BL.Address,
                Height = student_BL.Height,
                Weight = student_BL.Weight,
                Photo = student_BL.Photo,
                GradeId = student_BL.GradeId,
                TeacherId = student_BL.TeacherId,
            };
            return _student_DTO;
        }

        public Student_BL ConvertStudentEntityToBL(Student student)
        {
            Student_BL _student_BL = new Student_BL()
            {
                Id = student.Id,
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Height = student.Height,
                Weight = student.Weight,
                Photo = student.Photo,
                GradeId = student.GradeId,
                TeacherId = student.TeacherId,
            };
            return _student_BL;
        }
    }
}