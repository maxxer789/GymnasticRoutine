using DataAcces.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Contexts
{
    public partial class BaseContext : DbContext
    {
        public BaseContext()
        {

        }
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public virtual DbSet<ApparatusDTO> Apparatus { get; set; }
        public virtual DbSet<ElementDTO> Element { get; set; }
        public virtual DbSet<RoutineDTO> Routine { get; set; }
        public virtual DbSet<RoutineElementDTO> RoutineElement { get; set; }
        public virtual DbSet<SkillGroupDTO> SkillGroup { get; set; }
        public virtual DbSet<SkillLevelDTO> SkillLevel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=mssql.fhict.local;Database=dbi414805_gymroutine;User Id=dbi414805_gymroutine;Password=gymroutine");
            }
        }
    }
}
