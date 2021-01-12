using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class SkillLevel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Division { get; set; }
        public string AgeGroup { get; set; }

        public SkillLevel()
        {

        }

        public SkillLevel(int id, int level, string division, string ageGroup)
        {
            Id = id;
            Level = level;
            Division = division;
            AgeGroup = ageGroup;
        }
    }
}
