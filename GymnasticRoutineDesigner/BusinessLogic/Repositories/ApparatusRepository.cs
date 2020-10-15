using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Models;
using DataAcces.DTOs;
using DataAcces.Interfaces;

namespace BusinessLogic.Repositories
{
    public class ApparatusRepository
    {
        private readonly IApparatusContext _context;
        public ApparatusRepository(IApparatusContext context)
        {
            _context = context;
        }

        public IReadOnlyList<Apparatus> GetAllApparatus()
        {
            List<Apparatus> apparatuses = new List<Apparatus>();
            foreach(ApparatusDTO app  in _context.GetAllApparatus())
            {
                apparatuses.Add(new Apparatus(app.Id, app.Name, app.Abbreviation));
            }
            return apparatuses;
        }
    }
}
