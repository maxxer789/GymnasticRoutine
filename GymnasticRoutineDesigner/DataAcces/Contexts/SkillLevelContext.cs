using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class SkillLevelContext: BaseContext, ISkillLevelContext
    {
        public SkillLevelContext()
        {

        }

        public SkillLevelDTO GetById(int Id)
        {
            return SkillLevel.Where(sl => sl.Id == Id).FirstOrDefault();
        }
    }
}
