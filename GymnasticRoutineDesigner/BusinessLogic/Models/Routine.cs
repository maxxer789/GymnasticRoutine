﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Worth { get; set; }
        public Apparatus Apparatus { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public ICollection<Element> Elements { get; set; } = new List<Element>();

        public Routine()
        {

        }

        public Routine(int id, string name, double? worth, Apparatus apparatus, SkillLevel skillLevel, List<Element> elements)
        {
            Id = id;
            Name = name;
            Worth = worth;
            Apparatus = apparatus;
            SkillLevel = skillLevel;
            Elements = elements;
        }

        public Routine(string name, Apparatus apparatus, SkillLevel skillLevel)
        {
            Name = name;
            Apparatus = apparatus;
            SkillLevel = skillLevel;
        }
    }
}
