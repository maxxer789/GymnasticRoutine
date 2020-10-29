using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class SkillGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApparatusId { get; set; }

        public SkillGroup()
        {

        }

        public SkillGroup(int id, string name, int apparatusId)
        {
            Id = id;
            Name = name;
            ApparatusId = apparatusId;
        }
    }
}
