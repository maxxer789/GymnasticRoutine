using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IApparatusContext
    {
        ApparatusDTO GetApparatusById(int Id);
        IReadOnlyList<ApparatusDTO> GetAllApparatus();
        ApparatusDTO GetSkillGroupsFromApparatus(ApparatusDTO app);
    }
}
