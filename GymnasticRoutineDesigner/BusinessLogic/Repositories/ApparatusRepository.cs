using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.Models;
using BusinessLogic.Models.Converter;
using DataAcces.DTOs;
using DataAcces.Interfaces;

namespace BusinessLogic.Repositories
{
    public class ApparatusRepository
    {
        private readonly IApparatusContext _Context;
        public ApparatusRepository(IApparatusContext context)
        {
            _Context = context;
        }

        public Apparatus GetById(int id)
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetById(id));
        }
        public IReadOnlyList<Apparatus> GetAll()
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetAll().ToList());
        }
        public Apparatus GetSkillGroups(Apparatus app)
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetSkillGroups(DTOModelConverter.ModelToApparatusDTO(app)));
        }
    }
}
