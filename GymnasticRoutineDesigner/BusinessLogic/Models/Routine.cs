using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Worth { get; set; }
        public Apparatus Apparatus { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public ICollection<RoutineElement> Elements { get; set; }

        public Routine()
        {

        }

        public Routine(int id, string name, decimal worth, Apparatus apparatus, SkillLevel skillLevel, ICollection<RoutineElement> elements)
        {
            Id = id;
            Name = name;
            Worth = worth;
            Apparatus = apparatus;
            SkillLevel = skillLevel;
            Elements = elements;
        }

        public Routine(int id, string name, Apparatus apparatus)
        {
            Id = id;
            Name = name;
            Apparatus = apparatus;
        }
    }
}
