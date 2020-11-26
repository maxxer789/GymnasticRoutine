using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DTOs
{
    public class RoutineDTO
    {
        [Key]
        public int Id { get; set; }
        public decimal Worth { get; set; }
        public string Name { get; set; }
        public int ApparatusId { get; set; }
        [ForeignKey("ApparatusId")]
        public virtual ApparatusDTO Apparatus { get; set; }
        public int SkillLevelId { get; set; }
        [ForeignKey("SkillLevelId")]
        public virtual SkillLevelDTO SkillLevel { get; set; }

        public virtual ICollection<RoutineElementDTO> Element { get; set; }

        public RoutineDTO()
        {

        }
    }
}
