using DataAcces.DTOs;
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
        public SkillGroup(SkillGroupDTO dto)
        {
            Id = dto.Id;
            Apparatus = new Apparatus(dto.Apparatus);
            Name = dto.Name;
        }
    }
}
