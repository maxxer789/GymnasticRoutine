using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLogic.Models
{
    public class Apparatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public ICollection<SkillGroup> SkillGroups { get; set; }

        public Apparatus()
        {

        }

        public Apparatus(int id, string name, string abbreviation, List<SkillGroup> skillGroups)
        {
            Id = id;
            Name = name;
            Abbreviation = abbreviation;
            SkillGroups = skillGroups;
        }
    }
}
