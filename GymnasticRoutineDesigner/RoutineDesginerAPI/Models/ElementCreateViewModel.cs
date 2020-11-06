using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models
{
    public class ElementCreateViewModel
    {
        public int Priority { get; set; }
        public int SkillGroupId { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public decimal Worth { get; set; }
    }
}
