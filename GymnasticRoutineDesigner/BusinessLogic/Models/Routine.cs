using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public Apparatus ApparatusId { get; set; }
        public SkillLevel SkillLevelId { get; set; }
    }
}
