using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.DTOs
{
    public class SkillGroupDTO
    {
        public int Id { get; set; }
        public ApparatusDTO Apparatus { get; set; }
        public string Name { get; set; }

        public SkillGroupDTO()
        {

        }

        public SkillGroupDTO(int id, ApparatusDTO apparatus, string name)
        {
            Id = id;
            Apparatus.Id = apparatus.Id;
            Apparatus.Name = apparatus.Name;
            Apparatus.Abbreviation = apparatus.Abbreviation;
            Name = name;
        }
    }
}
