using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School_DataAccess.Interfaces;
using School_DataAccess.Models;
using School_Modles.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServiceHandler _StudentService;
        private readonly IWebHostEnvironment _env;

        public StudentController(IStudentServiceHandler studentService, IWebHostEnvironment env)
        {
            _StudentService = studentService;
            _env = env;
        }

        //GET: api/students
        [HttpGet]
        public IList<Student_DTO> GetStudents()
        {
            return _StudentService.RetriveStudents();
        }

        //GET: api/student/id
        [HttpGet("{id}")]
        public Student_DTO GetSingleStudent(int id)
        {
            return _StudentService.SingleResult(id);
        }

        //POST: api/AddStudent
        [HttpPost]
        public async Task<Student_DTO> AddStudent([FromForm] Student_VM student_vm, IFormFile image)
        {
            // "D:\\Aayush\\School_N_tier\\School_API\\UploadImage"
            // student_vm.Photo = image.FileName;
            var rootPath = "D:/Aayush/School_N_tier/School_API/UploadImage/";
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            FileStream fileObj = System.IO.File.Create(rootPath + image.FileName);
            {
                image.CopyTo(fileObj);
                fileObj.Flush();
            };
            var student = new Student()
            {
                Name = student_vm.Name,
                Address = student_vm.Address,
                GradeId = student_vm.GradeId,
                TeacherId = student_vm.TeacherId,
                Height = student_vm.Height,
                Weight = student_vm.Weight,
                Photo = fileObj.Name
            };
            return await _StudentService.AddStudent(student);
        }

        //PUT: api/UpdateStudent/student
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Student student)
        {
            return Ok(_StudentService.UpdateStudent(student));
        }

        //DELETE: api/DeleteStudent/id
        [HttpDelete("{id}")]
        public int DeleteStudent(int id)
        {
            return _StudentService.DeleteStudent(id);
        }

        //GET: api/TeacherAndGrade/id
        [HttpGet("studentId")]
        public Student_DTO GetTeacherAndGrade(int id)
        {
            return _StudentService.GetTecherAndGradeOfStudent(id);
        }
    }
}