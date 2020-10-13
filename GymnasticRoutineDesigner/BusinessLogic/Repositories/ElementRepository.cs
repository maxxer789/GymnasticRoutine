using BusinessLogic.Models;
using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repositories
{
    public class ElementRepository
    {
        private IElementContext _Context;
        public ElementRepository(IElementContext context)
        {
            _Context = context;
        }

        public IReadOnlyList<Element> GetAllElementsFromSkillGroup(SkillGroupDTO skillGroup)
        {
            List<Element> elements = new List<Element>();
            foreach(ElementDTO element in _Context.GetAllElementsFromSkillGroup(skillGroup))
            {
                elements.Add(new Element(element));
            }
            return elements.AsReadOnly();
        }
    }
}
