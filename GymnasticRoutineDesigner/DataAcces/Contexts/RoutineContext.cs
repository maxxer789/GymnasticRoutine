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
            Routine.Add(rout);
            return rout;
        }

        public RoutineDTO GetById(int Id)
        {
            return Routine.ToList().Where(r => r.Id == Id).FirstOrDefault();
        }
    }
}
