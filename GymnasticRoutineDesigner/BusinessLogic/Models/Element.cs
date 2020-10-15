using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; }
        public int Priority { get; }
        public string Name { get; }
        public string Difficulty { get; }
        public decimal Worth { get; }

        public int SkillGroupId { get; set; }
        public SkillGroup SkillGroup { get; set; }

        public Element()
        {

        }

        public Element(int id, SkillGroup skillGroup, int priority, string name, string difficulty, decimal worth)
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
