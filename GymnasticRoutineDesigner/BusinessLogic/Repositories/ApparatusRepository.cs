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

        public Apparatus GetApparatusById(int id)
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetApparatusById(id));
        }
        public IReadOnlyList<Apparatus> GetAllApparatus()
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetAllApparatus().ToList());
        }
        public Apparatus GetSkillGroupsFromApparatus(Apparatus app)
        {
            return DTOModelConverter.ApparatusDTOToModel(_Context.GetSkillGroupsFromApparatus(DTOModelConverter.ModelToApparatusDTO(app)));
        }
    }
}
