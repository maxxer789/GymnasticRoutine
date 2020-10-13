using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymnasticRoutineDesigner.Models
{
    public class SkillGroupViewModel
    {
        public int Id { get; set; }
        public ApparatusViewModel Apparatus { get; set; } = new ApparatusViewModel();
        public string Name { get; set; }

        public SkillGroupViewModel()
        {
                
        }
    }
}
