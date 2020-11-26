using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public int SkillGroupId { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public double Worth { get; set; }


        public Element()
        {
           
        }

        public Element(int id, int priority, int skillGroupId, string name, string difficulty, double worth)
        {
            Id = id;
            Priority = priority;
            SkillGroupId = skillGroupId;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
