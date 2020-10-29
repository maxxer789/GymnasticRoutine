﻿using BusinessLogic.Models;
using GymnasticRoutineDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models.ViewModelConverter
{
    public class ViewModelConverter
    {
        public static SkillGroupViewModel SkillGroupToViewModel(SkillGroup sg)
        {
            return new SkillGroupViewModel(sg.Id, sg.Name, sg.ApparatusId);
        }

        public static List<SkillGroupViewModel> SkillGroupToViewModel (List<SkillGroup> sgs)
        {
            List<SkillGroupViewModel> skillGroups = new List<SkillGroupViewModel>();
            foreach (SkillGroup sg in sgs)
            {
                skillGroups.Add(new SkillGroupViewModel(sg.Id, sg.Name, sg.ApparatusId));
            }
            return skillGroups;
        }
        
        public static ApparatusViewModel ApparatusToViewModel(Apparatus app)
        {
            return new ApparatusViewModel(app.Id, app.Name, app.Abbreviation, SkillGroupToViewModel(app.SkillGroups.ToList()));
        }
    }
}
