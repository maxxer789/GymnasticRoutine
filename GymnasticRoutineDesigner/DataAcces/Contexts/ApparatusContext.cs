using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class ApparatusContext: BaseContext, IApparatusContext
    {
        public ApparatusContext()
        {

        }

        public IReadOnlyList<ApparatusDTO> GetAllApparatus()
        {
            List<ApparatusDTO> app = Apparatus.ToList();
            foreach(ApparatusDTO apd in app)
            {
                apd.SkillGroups = SkillGroup.Where(s => s.ApparatusId == apd.Id).ToList();
                foreach(SkillGroupDTO sgd in apd.SkillGroups)
                {
                    sgd.Elements = Element.Where(e => e.SkillGroupId == sgd.Id).ToList();
                }
            }
            return app;
        }
    }
}
