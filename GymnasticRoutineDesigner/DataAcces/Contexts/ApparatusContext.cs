using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class ApparatusContext:DbContext, IApparatusContext
    {
        public DbSet<ApparatusDTO> Apparatus { get; set; }
        public DbSet<SkillGroupDTO> SkillGroup { get; set; }

        public ApparatusContext(DbContextOptions<ApparatusContext> options):base(options)
        {

        }


        public IReadOnlyList<ApparatusDTO> GetAllApparatus()
        {
            return Apparatus.ToList();
        }
    }
}
