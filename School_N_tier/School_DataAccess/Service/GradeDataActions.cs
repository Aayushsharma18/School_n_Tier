using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School_DataAccess.Interfaces;
using School_Modles.Models;

#nullable disable
namespace School_DataAccess.Service
{
    public class GradeDataActions : IGradeActionManager
    {
        private readonly SchoolContext _context;

        public GradeDataActions(SchoolContext context)
        {
            _context = context;
        }
        public async Task<Grade> AddGrades(Grade grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return grade;
        }

        public async Task<Grade> DeleteGrades(int id)
        {
            var grade = _context.Grades.Where(x => x.Id == id).FirstOrDefault();
            _context.Entry(grade).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return grade;
        }

        public IList<Grade> GetGrades()
        {
            return _context.Grades.ToList();
        }

        public Grade GetSingleGrade(int id)
        {
            return _context.Grades.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<Grade> UpdateGrades(Grade grade)
        {
            var existing = _context.Grades.Where(x => x.Id == grade.Id).FirstOrDefault();
            existing.Id = grade.Id;
            existing.Name = grade.Name;
            existing.Section = grade.Section;
            _context.Entry(grade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return grade;
        }
    }
}