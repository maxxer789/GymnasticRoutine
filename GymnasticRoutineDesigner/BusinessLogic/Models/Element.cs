using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public SkillGroup SkillGroup { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public double Worth { get; set; }


        public Element()
        {
           
        }

        public Element(int id, int priority, SkillGroup skillGroup, string name, string difficulty, double worth)
        {
            Id = id;
            Priority = priority;
            SkillGroup = skillGroup;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
