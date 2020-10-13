using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; }
        public SkillGroup SkillGroup { get; }
        public int Priority { get; }
        public string Name { get; }
        public string Difficulty { get; }
        public decimal Worth { get; }

        public Element()
        {

        }

        public Element(ElementDTO dto)
        {
            Id = dto.Id;
            SkillGroup = new SkillGroup(dto.SkillGroup);
            Priority = dto.Priority;
            Name = dto.Name;
            Difficulty = dto.Difficulty;
            Worth = dto.Worth;
        }
    }
}
