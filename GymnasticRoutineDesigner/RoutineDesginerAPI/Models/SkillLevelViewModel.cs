﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models
{
    public class SkillLevelViewModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Division { get; set; }
        public string AgeGroup { get; set; }

        public SkillLevelViewModel()
        {

        }

        public SkillLevelViewModel(int id, int level, string division, string ageGroup)
        {
            Id = id;
            Level = level;
            Division = division;
            AgeGroup = ageGroup;
        }
    }
}
