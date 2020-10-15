using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DTOs
{
    public class ElementDTO
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int Priority { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string Difficulty { get; set; }
        [Column(TypeName = "decimal(1,1)")]
        public decimal Worth { get; set; }

        public int SkillGroupId { get; set; }
        public SkillGroupDTO SkillGroup { get; set; }

        public ElementDTO()
        {

        }

        public ElementDTO(int id, SkillGroupDTO skillGroup, int priority, string name, string difficulty, decimal worth)
        {
            Id = id;
            SkillGroup = skillGroup;
            Priority = priority;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
