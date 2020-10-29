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
        [ForeignKey("SkillGroupId")]
        public virtual SkillGroupDTO SkillGroup { get; set; }
    }
}
