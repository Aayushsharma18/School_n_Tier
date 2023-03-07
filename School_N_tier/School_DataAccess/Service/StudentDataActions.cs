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
    public class StudentDataActions : IStudentActionManager
    {
        private readonly SchoolContext _context;
        public StudentDataActions(SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> RetrieveStudents()
        {
            var students = _context.Students.ToList();
            return students;
        }
        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public int DeleteStudent(int id)
        {
            var deleteStudent = _context.Students.Where(x => x.Id == id);
            _context.Remove(deleteStudent);
            _context.SaveChanges();
            return id;
        }

        public Student UpdateStudent(Student student)
        {
            var existing = _context.Students.FirstOrDefault(x => x.Id == student.Id);
            existing.Id = student.Id;
            existing.Name = student.Name;
            existing.DateOfBirth = student.DateOfBirth;
            existing.Address = student.Address;
            existing.Photo = student.Photo;
            existing.Height = student.Height;
            existing.Weight = student.Weight;
            existing.GradeId = student.GradeId;

            _context.Entry(existing).State = EntityState.Modified;
            _context.SaveChanges();
            return existing;
        }

        public IQueryable<Student> SingleStudent(int id)
        {
            return _context.Students.Where(x => x.Id == id);
        }

        public IQueryable<Student> GetTeacherAndGrade(int id)
        {
            var student = _context.Students.Where(x => x.Id == id)
            .Include(x => x.Teacher)
            .Include(x => x.Grade);
            return student;
        }
    }
}