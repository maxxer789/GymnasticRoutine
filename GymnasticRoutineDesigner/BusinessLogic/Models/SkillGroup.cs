using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class SkillGroup
    {
        public int Id { get; set; }
        public Apparatus Apparatus { get; set; }
        public string Name { get; set; }

        public SkillGroup()
        {

        }
        public SkillGroup(int id, Apparatus app, string name)
        {
            Id = id;
            Apparatus = app;
            Name = name;
        }
    }
}
