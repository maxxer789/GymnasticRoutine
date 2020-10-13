using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.DTOs
{
    public class ElementDTO
    {
        public int Id { get; set; }
        public SkillGroupDTO SkillGroup { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public decimal Worth { get; set; }

        public ElementDTO()
        {

        }

        public ElementDTO(int id, SkillGroupDTO skillGroup, int priority, string name, string difficulty, decimal worth)
        {
            Id = id;
            SkillGroup = skillGroup;
            Priority = priority;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
