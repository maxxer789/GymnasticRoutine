using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class SkillGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Element> Elements { get; set; }

        public SkillGroup()
        {
            Elements = new List<Element>();
        }

        public SkillGroup(int id, string name, ICollection<Element> elements)
        {
            Id = id;
            Name = name;
            Elements = elements;
        }

        public SkillGroup(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
