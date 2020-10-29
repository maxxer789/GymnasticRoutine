using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymnasticRoutineDesigner.Models
{
    public class SkillGroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ElementViewModel> Elements { get; set; }

        public SkillGroupViewModel()
        {
            Elements = new List<ElementViewModel>();
        }

        public SkillGroupViewModel(int id, string name, ICollection<ElementViewModel> elements)
        {
            Id = id;
            Name = name;
            Elements = elements;
        }
    }
}
