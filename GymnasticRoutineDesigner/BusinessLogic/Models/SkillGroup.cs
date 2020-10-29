using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class SkillGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Apparatus Apparatus { get; set; }
        public ICollection<Element> Elements { get; set; }

        public SkillGroup()
        {

        }

        public SkillGroup(int id, string name, Apparatus apparatus, ICollection<Element> elements)
        {
            Id = id;
            Name = name;
            Apparatus = apparatus;
            Elements = elements;
        }
    }
}
