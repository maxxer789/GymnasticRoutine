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
        public int ApparatusId { get; set; }

        public SkillGroupViewModel()
        {
                
        }

        public SkillGroupViewModel(int id, string name, int apparatusId)
        {
            Id = id;
            Name = name;
            ApparatusId = apparatusId;
        }
    }
}
