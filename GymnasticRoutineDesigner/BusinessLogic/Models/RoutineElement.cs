using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class RoutineElement
    {
        public int Id { get; set; }
        public int RoutineId { get; set; }
        public int ElementId { get; set; }

        public RoutineElement()
        {

        }

        public RoutineElement(int id, int routineId, int elementId)
        {
            Id = id;
            RoutineId = routineId;
            ElementId = elementId;
        }

        public RoutineElement(int routineId, int elementId)
        {
            RoutineId = routineId;
            ElementId = elementId;
        }
    }
}
