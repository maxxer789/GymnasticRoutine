using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Contexts
{
    public class SkillLevelContext: DbContext, ISkillLevelContext
    {
        public DbSet<SkillLevelDTO> SkillLevel { get; set; }
        public DbSet<ApparatusDTO> Apparatus { get; set; }

        public SkillLevelContext(DbContextOptions<SkillLevelContext> options) : base(options)
        {

        }
    }
}
