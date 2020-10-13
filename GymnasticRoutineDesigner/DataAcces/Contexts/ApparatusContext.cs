using DataAcces.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Contexts
{
    public class ApparatusContext:DbContext
    {
        public ApparatusContext(DbContextOptions<ApparatusContext> options):base(options)
        {

        }
        public DbSet<ApparatusDTO> Apparatus { get; set; }
    }
}
