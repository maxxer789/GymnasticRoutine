using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class SkillGroupContext : BaseContext, ISkillGroupContext
    {
        public SkillGroupContext()
        {

        }

        public IReadOnlyList<SkillGroupDTO> GetAllSkillGroups()
        {
            List<SkillGroupDTO> groups = SkillGroup.ToList();
            foreach(SkillGroupDTO sg in groups)
            {
                sg.Elements = Element.Where(e => e.SkillGroupId == sg.Id).ToList();
            }
            return groups;
        }
    }
}
