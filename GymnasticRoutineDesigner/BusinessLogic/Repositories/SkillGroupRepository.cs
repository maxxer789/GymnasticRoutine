using BusinessLogic.Models;
using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repositories
{
    public class SkillGroupRepository
    {
        private ISkillGroupContext _Context;
        public SkillGroupRepository(ISkillGroupContext context)
        {
            _Context = context;
        }

        //public IReadOnlyList<SkillGroup> GetSkillGroupsFromApparatus(ApparatusDTO apparatus)
        //{
        //    IReadOnlyList<SkillGroupDTO> skillGroupDTOs = _Context.GetSkillGroupsFromApparatus(apparatus);
        //    List<SkillGroup> skillGroups = new List<SkillGroup>();
        //    foreach (SkillGroupDTO dto in skillGroupDTOs)
        //    {
        //        skillGroups.Add(new SkillGroup(dto.Id, new Apparatus(dto.Apparatus.Id, dto.Apparatus.Name, dto.Apparatus.Abbreviation), dto.Name));
        //    }
        //    return _Context.GetSkillGroupsFromApparatus(apparatus);
        //}
    }
}
