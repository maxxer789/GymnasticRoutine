using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymnasticRoutineDesigner.Models;

namespace RoutineDesginerAPI.Models
{
    public class RoutineCreateViewModel
    {
        public string Name { get; set; }
        public ApparatusViewModel Apparatus { get; set; }
        public SkillLevelViewModel SkillLevel { get; set; }

        public RoutineCreateViewModel()
        {

        }

        public RoutineCreateViewModel(string name, ApparatusViewModel apparatus, SkillLevelViewModel skillLevel)
        {
            Name = name;
            Apparatus = apparatus;
            SkillLevel = skillLevel;
        }
    }
}
