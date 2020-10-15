using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DTOs
{
    public class ApparatusDTO
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string Abbreviation { get; set; }

        public IList<SkillGroupDTO> SkillGroups { get; set; }

        public ApparatusDTO()
        {

        }

        public ApparatusDTO(int id, string name, string abbreviation)
        {
            Id = id;
            Name = name;
            Abbreviation = abbreviation;
        }
    }
}
