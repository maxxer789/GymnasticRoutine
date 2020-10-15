using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymnasticRoutineDesigner.Models
{
    public class ElementViewModel
    {
        public int Id { get; }
        public int Priority { get; }
        public string Name { get; }
        public string Difficulty { get; }
        public decimal Worth { get; }

        public int SkillGroupId { get; set; }
        public SkillGroupViewModel SkillGroup { get; set; } = new SkillGroupViewModel();
        public ElementViewModel()
        {

        }
    }
}
