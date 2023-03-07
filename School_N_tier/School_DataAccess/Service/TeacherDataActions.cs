using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_DataAccess.Interfaces;
using School_DataAccess.Models;
using School_Modles.Models;

namespace School_DataAccess.Service
{
    public class TeacherDataActions : ITeacherActionManager
    {
        public readonly SchoolContext _context;

        public TeacherDataActions(SchoolContext context)
        {
            _context = context;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            _context.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public int DeleteTeacher(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return id;
        }

        public IQueryable<Teacher> GetTeacher(int id)
        {
            var teacher = _context.Teachers.Where(x => x.Id == id);
            return teacher;
        }

        public IList<Teacher> GetTeachers()
        {
            return _context.Teachers.AsEnumerable().ToList();
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            var existing = _context.Teachers.Where(x => x.Id == teacher.Id);
            _context.Update(teacher);
            _context.SaveChanges();
            return teacher;
        }
    }
}