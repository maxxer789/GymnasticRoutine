using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class RoutineContext : BaseContext, IRoutineContext
    {
        public RoutineDTO Create(RoutineDTO rout)
        {
            rout.SkillLevel = SkillLevel.Where(sl => sl.Id == 1).FirstOrDefault();
            rout.Apparatus = Apparatus.Where(app => app.Id == rout.ApparatusId).FirstOrDefault();
            rout.Apparatus.SkillGroups = FillSkillGroups(rout.Apparatus);
            Routine.Add(rout);
            SaveChanges();
            return rout;
        }

        public RoutineDTO GetById(int Id)
        {
            return Routine.ToList().Where(r => r.Id == Id).FirstOrDefault();
        }

        private List<SkillGroupDTO> FillSkillGroups(ApparatusDTO app)
        {
            List<SkillGroupDTO> sgs = SkillGroup.Where(sg => sg.ApparatusId == app.Id).ToList();

            foreach (SkillGroupDTO sg in sgs)
            {
                sg.Elements = Element.Where(e => e.SkillGroupId == sg.Id).ToList();
            }

            return sgs;
        }
    }
}
