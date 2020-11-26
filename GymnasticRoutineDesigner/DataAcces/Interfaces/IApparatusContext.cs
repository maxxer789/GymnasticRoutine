using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IApparatusContext
    {
        ApparatusDTO GetById(int Id);
        IReadOnlyList<ApparatusDTO> GetAll();
        ApparatusDTO GetSkillGroups(int Id);
    }
}
