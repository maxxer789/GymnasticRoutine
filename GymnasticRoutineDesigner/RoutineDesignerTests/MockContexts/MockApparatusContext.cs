
using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoutineDesignerTests.MockContexts
{
    class MockApparatusContext : IApparatusContext
    {
        private readonly List<ApparatusDTO> apparatus = new List<ApparatusDTO>();
        public MockApparatusContext()
        {
            for (int i = 0; i < 4; i++)
            {
                List<ElementDTO> elements = new List<ElementDTO>();
                elements.Add(new ElementDTO(i, 1, i, "element" + i, "A", 0.1));
                elements.Add(new ElementDTO(i, 1, i, "element" + i, "B", 0.2));

                List<SkillGroupDTO> skillGroups = new List<SkillGroupDTO>();
                skillGroups.Add(new SkillGroupDTO(i, "SkillGroup" + i, elements));

                apparatus.Add(new ApparatusDTO(i, "Apparatus" + i, "A" + i, skillGroups));
            }
        }

        public ApparatusDTO GetById(int Id)
        {
            try
            {
                return apparatus.Find(a => a.Id == Id);
            }
            catch (NullReferenceException)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public IReadOnlyList<ApparatusDTO> GetAll()
        {
            return apparatus.AsReadOnly();
        }

        public ApparatusDTO GetSkillGroups(int Id)
        {
            return apparatus.Find(a => a.Id == Id);
        }
    }
}
