using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_DataAccess.Interfaces;
using School_Modles.Models;
using School_Services.Interface;
using School_Services.Models;

namespace School_Services.Repository
{
    public class GradeServiceHandlerRepository : IGradeServiceHandler
    {
        private readonly IGradeActionManager _gradeActionManager;
        private readonly IMapperClass _mapper;

        public GradeServiceHandlerRepository(IGradeActionManager gradeActionManager, IMapperClass mapper)
        {
            _gradeActionManager = gradeActionManager;
            _mapper = mapper;
        }

        public async Task<Grade_DTO> AddGrade(Grade grade)
        {
            var newGrade = await _gradeActionManager.AddGrades(grade);

            var grade_BL = _mapper.ConvertGradeEntityToBL(newGrade);

            var grade_DTO = _mapper.ConvertGradeBLToDTO(grade_BL);

            return grade_DTO;
        }

        public async Task<Grade_DTO> DeleteGrade(int id)
        {
            var deleteGrade = await _gradeActionManager.DeleteGrades(id);

            var grade_BL = _mapper.ConvertGradeEntityToBL(deleteGrade);

            var grade_DTO = _mapper.ConvertGradeBLToDTO(grade_BL);

            return grade_DTO;
        }

        public IList<Grade_DTO> GetGrades()
        {
            var gradeList = _gradeActionManager.GetGrades();

            var newGrade_DTO = new List<Grade_DTO>();

            foreach (var grade in gradeList)
            {
                var grade_BL = _mapper.ConvertGradeEntityToBL(grade);

                var grade_DTO = _mapper.ConvertGradeBLToDTO(grade_BL);

                newGrade_DTO.Add(grade_DTO);
            }

            return newGrade_DTO;
        }

        public Grade_DTO GetSingleGrade(int id)
        {
            var grade = _gradeActionManager.GetSingleGrade(id);

            var grade_BL = _mapper.ConvertGradeEntityToBL(grade);

            var grade_DTO = _mapper.ConvertGradeBLToDTO(grade_BL);

            return grade_DTO;
        }

        public async Task<Grade_DTO> UpdateGrade(Grade grade)
        {
            var updateGrade = await _gradeActionManager.UpdateGrades(grade);

            var grade_BL = _mapper.ConvertGradeEntityToBL(updateGrade);

            var grade_DTO = _mapper.ConvertGradeBLToDTO(grade_BL);

            return grade_DTO;
        }
    }
}