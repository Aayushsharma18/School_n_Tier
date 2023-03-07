using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School_DataAccess.Interfaces;
using School_Modles.Models;
using School_Services;
using School_Services.Models;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeServiceHandler _GradeService;

        public GradeController(IGradeServiceHandler gradeService)
        {
            _GradeService = gradeService;
        }

        //GET: api/Grades
        [HttpGet]
        public IList<Grade_DTO> GetGrades()
        {
            return _GradeService.GetGrades();
        }

        //GET: api/student/id
        [HttpGet("{id}")]
        public Grade_DTO GetSingleGrade(int id)
        {
            return _GradeService.GetSingleGrade(id);
        }

        //POST: api/Grade
        [HttpPost]
        public async Task<Grade_DTO> AddGrade(Grade grade)
        {
            return await _GradeService.AddGrade(grade);
        }

        //PUT: api/Grade/id
        [HttpPut("{id}")]
        public async Task<Grade_DTO> UpdateGrade(Grade grade)
        {
            return await _GradeService.UpdateGrade(grade);
        }

        //DELETE: api/Grade/id
        [HttpDelete("{id}")]
        public async Task<Grade_DTO> DeleteGrade(int id)
        {
            return await _GradeService.DeleteGrade(id);
        }
    }
}