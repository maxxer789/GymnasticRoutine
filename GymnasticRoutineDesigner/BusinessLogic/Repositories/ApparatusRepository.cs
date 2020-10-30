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
                    List<Element> elements = new List<Element>();

                    foreach(ElementDTO ed in sgd.Elements)
                    {
                        elements.Add(new Element(ed.Id, ed.Priority, ed.Name, ed.Difficulty, ed.Worth));
                    }

                    groups.Add(new SkillGroup(sgd.Id, sgd.Name, elements));
                }

                apparatuses.Add(new Apparatus(app.Id, app.Name, app.Abbreviation, groups));
            }
            return apparatuses;
        }
    }
}
