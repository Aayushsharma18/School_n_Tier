using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Buinesslogic.Models;
using School_DataAccess.Interfaces;
using School_Modles.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_Services.Repository
{
    public class StudentServiceHandlerRepository : IStudentServiceHandler
    {
        public readonly IStudentActionManager _studentActionManager;
        public readonly IMapperClass _mapper;

        public StudentServiceHandlerRepository(IStudentActionManager studentActionManager, IMapperClass mapper)
        {
            _studentActionManager = studentActionManager;
            _mapper = mapper;
        }
        public async Task<Student_DTO> AddStudent(Student student)
        {
            var newStudent = await _studentActionManager.AddStudent(student);

            var newStudentBL = _mapper.ConvertStudentEntityToBL(newStudent);

            var newStudentDTO = _mapper.ConvertStudentBLToDTO(newStudentBL);

            return newStudentDTO;
        }

        public int DeleteStudent(int id)
        {
            return _studentActionManager.DeleteStudent(id);
        }

        public Student_DTO GetTecherAndGradeOfStudent(int id)
        {
            var studentTeacherAndGrade = _studentActionManager.GetTeacherAndGrade(id).First();

            var studentTeacherAndGradeBL = _mapper.ConvertStudentEntityToBL(studentTeacherAndGrade);

            var studentTeacherAndGradeDTO = _mapper.ConvertStudentBLToDTO(studentTeacherAndGradeBL);

            return studentTeacherAndGradeDTO;

        }

        public IList<Student_DTO> RetriveStudents()
        {
            var studentsList = _studentActionManager.RetrieveStudents();

            var studentlistDTO = new List<Student_DTO>();

            foreach (var student in studentsList)
            {
                var studentBL = _mapper.ConvertStudentEntityToBL(student);
                studentlistDTO.Add(_mapper.ConvertStudentBLToDTO(studentBL));
            }

            return studentlistDTO;

        }

        public Student_DTO SingleResult(int id)
        {
            var student = _studentActionManager.SingleStudent(id).First();

            Student_BL studentBL = _mapper.ConvertStudentEntityToBL(student);

            Student_DTO studentDTO = _mapper.ConvertStudentBLToDTO(studentBL);

            return studentDTO;
        }

        public Student_DTO UpdateStudent(Student student)
        {
            var updateStudent = _studentActionManager.UpdateStudent(student);

            var updateStudentBL = _mapper.ConvertStudentEntityToBL(updateStudent);

            var updateStudentDTO = _mapper.ConvertStudentBLToDTO(updateStudentBL);

            return updateStudentDTO;
        }

    }
}