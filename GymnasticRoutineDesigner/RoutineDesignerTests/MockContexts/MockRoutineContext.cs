using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoutineDesignerTests.MockContexts
{
    class MockRoutineContext : IRoutineContext
    {
        private readonly List<RoutineDTO> Routines = new List<RoutineDTO>();

        public MockRoutineContext()
        {
            List<SkillGroupDTO> skillGroups = new List<SkillGroupDTO>();
            skillGroups.Add(new SkillGroupDTO(1, "skill group 1", new List<ElementDTO>()));
            ApparatusDTO app = new ApparatusDTO(1, "apparatus 1", "a1", skillGroups);
            List<ElementDTO> elements = new List<ElementDTO>();
            List<RoutineElementDTO> routineElements = new List<RoutineElementDTO>();
            for (int i = 1; i < 2; i++)
            {
                elements.Add(new ElementDTO(i, 1, "Element" + i, "A", 0.1));
                routineElements.Add(new RoutineElementDTO(i, 1, i));
                routineElements[i - 1].Element = elements[i - 1];
            }
            Routines.Add(new RoutineDTO(1, 0.2, "Routine 1", 1, 1, null));
            routineElements[0].Routine = Routines[0];
            Routines[0].Elements = routineElements;
            Routines[0].Apparatus = app;
            Routines[0].SkillLevel = new SkillLevelDTO(1, 1, "divisie 1", "age 17");
        }

        public RoutineDTO Create(RoutineDTO routine)
        {
            try
            {
                Routines.Add(routine);
                routine.Id = Routines[Routines.Count - 1].Id + 1;
                return routine;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public RoutineDTO GetById(int Id)
        {
            return Routines.Find(r => r.Id == Id);
        }

        public RoutineDTO AddElement(RoutineElementDTO re)
        {
            RoutineDTO routine = Routines.Find(r => r.Id == re.RoutineId);
            routine.Elements.Add(re);
            return routine;
        }
    }
}
