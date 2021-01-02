using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models
{
    public class RoutineCreateViewModel
    {
        public string Name { get; set; }
        public int ApparatusId { get; set; }
        public int SkillLevelId { get; set; }

        public RoutineCreateViewModel()
        {

        }

        public RoutineCreateViewModel(string name, int apparatusId, int skillLevelId)
        {
            Name = name;
            ApparatusId = apparatusId;
            SkillLevelId = skillLevelId;
        }
    }
}
