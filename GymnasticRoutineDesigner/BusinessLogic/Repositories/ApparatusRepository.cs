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
            foreach (ApparatusDTO app in _context.GetAllApparatus())
            {
                List<SkillGroup> groups = new List<SkillGroup>();

                foreach (SkillGroupDTO sgd in app.SkillGroups)
                {
                    groups.Add(new SkillGroup
                    {
                        Id = sgd.Id,
                        Name = sgd.Name
                    });
                }

                apparatuses.Add(new Apparatus { 
                Id = app.Id,
                Name = app.Name,
                Abbreviation = app.Abbreviation,
                SkillGroups = groups
                });
            }
            return apparatuses;
        }
    }
}
