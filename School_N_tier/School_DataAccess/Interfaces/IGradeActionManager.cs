using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Modles.Models;

namespace School_DataAccess.Interfaces
{
    public interface IGradeActionManager
    {
        IList<Grade> GetGrades();
        Grade GetSingleGrade(int id);
        Task<Grade> AddGrades(Grade grade);
        Task<Grade> UpdateGrades(Grade grade);
        Task<Grade> DeleteGrades(int id);
    }
}