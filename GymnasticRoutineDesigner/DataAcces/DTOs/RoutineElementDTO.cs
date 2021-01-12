using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcces.DTOs
{
    public class RoutineElementDTO
    {
        public int Id { get; set; }
        public int RoutineId { get; set; }
        [ForeignKey("RoutineId")]
        public virtual RoutineDTO Routine { get; set; }
        public int ElementId { get; set; }
        [ForeignKey("ElementId")]
        public virtual ElementDTO Element { get; set; }
        public RoutineElementDTO()
        {

        }

        public RoutineElementDTO(int routineId, int elementId)
        {
            RoutineId = routineId;
            ElementId = elementId;
        }

        public RoutineElementDTO(int id, int routineId, int elementId)
        {
            Id = id;
            RoutineId = routineId;
            ElementId = elementId;
        }
    }
}
