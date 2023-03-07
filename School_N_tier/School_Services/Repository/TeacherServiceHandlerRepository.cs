using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_DataAccess.Interfaces;
using School_DataAccess.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_Services.Repository
{
    public class TeacherServiceHandlerRepository : ITeacherServiceHandler
    {
        public readonly ITeacherActionManager _teacherActionManager;

        public readonly IMapperClass _Mapper;

        public TeacherServiceHandlerRepository(ITeacherActionManager teacherActionManager, IMapperClass mapper)
        {
            _teacherActionManager = teacherActionManager;
            _Mapper = mapper;
        }
        public Teacher_DTO AddTeacher(Teacher teacher)
        {
            var newTeacher = _teacherActionManager.AddTeacher(teacher);

            var teacher_BL = _Mapper.ConvertTeacherEntityToBL(newTeacher);

            var teacher_DTO = _Mapper.ConvertTeacherBLToDTO(teacher_BL);

            return teacher_DTO;
        }

        public int DeletTeacher(int id)
        {
            return _teacherActionManager.DeleteTeacher(id);
        }

        public Teacher_DTO GetTeacher(int id)
        {
            var teacher = _teacherActionManager.GetTeacher(id).First();

            var teacher_BL = _Mapper.ConvertTeacherEntityToBL(teacher);

            var teacher_DTO = _Mapper.ConvertTeacherBLToDTO(teacher_BL);

            return teacher_DTO;
        }

        public IList<Teacher_DTO> GetTeachers()
        {
            var teacherList = _teacherActionManager.GetTeachers();

            var newTeacherList_DTO = new List<Teacher_DTO>();

            foreach (var teacher in teacherList)
            {
                var teacher_BL = _Mapper.ConvertTeacherEntityToBL(teacher);

                var teacher_DTO = _Mapper.ConvertTeacherBLToDTO(teacher_BL);

                newTeacherList_DTO.Add(teacher_DTO);
            }
            return newTeacherList_DTO;
        }

        public Teacher_DTO UpdateTeacher(Teacher teacher)
        {
            var updateTeacher = _teacherActionManager.UpdateTeacher(teacher);

            var teacher_BL = _Mapper.ConvertTeacherEntityToBL(updateTeacher);

            var teacher_DTO = _Mapper.ConvertTeacherBLToDTO(teacher_BL);

            return teacher_DTO;
        }

    }
}