using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IElementContext
    {
        IReadOnlyList<ElementDTO> GetAllElementsFromSkillGroup(SkillGroupDTO skillGroup);
    }
}
