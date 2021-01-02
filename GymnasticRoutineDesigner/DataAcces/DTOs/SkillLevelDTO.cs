using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.DTOs
{
    public class SkillLevelDTO
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Division { get; set; }
        public string AgeGroup { get; set; }

        public SkillLevelDTO()
        {

        }
    }
}
