using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Modles.Models;
using School_Services.Models;

namespace School_Services
{
    public interface IGradeServiceHandler
    {
        IList<Grade_DTO> GetGrades();
        Grade_DTO GetSingleGrade(int id);
        Task<Grade_DTO> AddGrade(Grade grade);
        Task<Grade_DTO> UpdateGrade(Grade grade);
        Task<Grade_DTO> DeleteGrade(int id);

    }
}