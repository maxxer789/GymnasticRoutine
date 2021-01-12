using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models
{
    public class AddElementToRoutineViewModel
    {
        public int RoutineId { get; set; }
        public int ElementId { get; set; }

        public AddElementToRoutineViewModel()
        {

        }
        public AddElementToRoutineViewModel(int routineId, int elementId)
        {
            RoutineId = routineId;
            ElementId = elementId;
        }
    }
}
