using BusinessLogic.Models;
using BusinessLogic.Models.Converter;
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

        public Element Create(Element El)
        {
            return DTOModelConverter.ElementDTOToModel(_Context.Create(DTOModelConverter.ModelToElementDTO(El)));
        }

        public Element GetById(int Id)
        {
            return DTOModelConverter.ElementDTOToModel(_Context.GetById(Id));
        }
    }
}
