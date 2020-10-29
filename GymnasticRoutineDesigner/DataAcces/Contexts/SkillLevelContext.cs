using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Contexts
{
    public class SkillLevelContext: BaseContext, ISkillLevelContext
    {
        public SkillLevelContext()
        {

        }
    }
}
