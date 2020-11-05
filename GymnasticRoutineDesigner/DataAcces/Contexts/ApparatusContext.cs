using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class ApparatusContext : BaseContext, IApparatusContext
    {
        public ApparatusDTO GetApparatusById(int Id)
        {
            ApparatusDTO app = Apparatus.ToList().Find(a => a.Id == Id);

            app.SkillGroups = FillSkillGroups(app);

            return app;
        }

        public IReadOnlyList<ApparatusDTO> GetAllApparatus()
        {
            List<ApparatusDTO> app = Apparatus.ToList();

            foreach (ApparatusDTO apd in app)
            {
                apd.SkillGroups = FillSkillGroups(apd);
            }

            return app;
        }
        public ApparatusDTO GetSkillGroupsFromApparatus(ApparatusDTO app)
        {
            app.SkillGroups = FillSkillGroups(app);

            return app;
        }

        private List<SkillGroupDTO> FillSkillGroups(ApparatusDTO app)
        {
            List<SkillGroupDTO> sgs = SkillGroup.Where(sg => sg.ApparatusId == app.Id).ToList();

            foreach(SkillGroupDTO sg in sgs)
            {
                sg.Elements = Element.Where(e => e.SkillGroupId == sg.Id).ToList();
            }

            return sgs;
        }
    }
}
