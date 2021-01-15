using GymnasticRoutineDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models
{
    public class RoutineViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Worth { get; set; }
        public ApparatusViewModel Apparatus { get; set; }
        public SkillLevelViewModel SkillLevel { get; set; }
        public ICollection<ElementViewModel> Elements { get; set; }

        public RoutineViewModel()
        {

        }

        public RoutineViewModel(int id, string name, double? worth, ApparatusViewModel apparatus, SkillLevelViewModel skillLevel, ICollection<ElementViewModel> elements)
        {
            Id = id;
            Name = name;
            Worth = worth;
            Apparatus = apparatus;
            SkillLevel = skillLevel;
            Elements = elements;
        }
    }
}
