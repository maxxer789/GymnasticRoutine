﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DTOs
{
    public class SkillGroupDTO
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        public int ApparatusId { get; set; }
        [ForeignKey("ApparatusId")]
        public virtual ApparatusDTO Apparatus { get; set; }

        public virtual ICollection<ElementDTO> Elements { get; set; }

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
