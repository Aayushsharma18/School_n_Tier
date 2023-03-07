using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School_DataAccess.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController
    {
        private readonly ITeacherServiceHandler _TeacherService;
        public TeacherController(ITeacherServiceHandler teacherService)
        {
            _TeacherService = teacherService;
        }

        //GET: api/Teachers
        [HttpGet]
        public IList<Teacher_DTO> GetTeachers()
        {
            return _TeacherService.GetTeachers();
        }

        //GET: api/Teacher/id
        [HttpGet("{id}")]
        public Teacher_DTO GetTeacher(int id)
        {
            return _TeacherService.GetTeacher(id);
        }

        //POST: api/Teacher
        [HttpPost]
        public Teacher_DTO AddTeacher(Teacher teacher)
        {
            return _TeacherService.AddTeacher(teacher);
        }

        //PUT: api/Teacher/id
        [HttpPut("{id}")]
        public Teacher_DTO UpdateTeacher(Teacher teacher)
        {
            return _TeacherService.UpdateTeacher(teacher);
        }

        //Delete: api/Teacher/id
        [HttpDelete("{id}")]
        public int DeleteTeacher(int id)
        {
            return _TeacherService.DeletTeacher(id);
        }
    }
}