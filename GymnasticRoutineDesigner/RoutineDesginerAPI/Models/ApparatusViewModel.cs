using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymnasticRoutineDesigner.Models
{
    public class ApparatusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public ICollection<SkillGroupViewModel> SkillGroups { get; set; }

        public ApparatusViewModel()
        {
            SkillGroups = new List<SkillGroupViewModel>();
        }

        public ApparatusViewModel(int id, string name, string abbreviation, List<SkillGroupViewModel> skillGroups)
        {
            Id = id;
            Name = name;
            Abbreviation = abbreviation;
            SkillGroups = skillGroups;
        }
    }
}
