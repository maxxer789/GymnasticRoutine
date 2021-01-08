using BusinessLogic.Models;
using BusinessLogic.Models.Converter;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repositories
{
    public class SkillLevelRepository
    {
        private readonly ISkillLevelContext _Context;
        public SkillLevelRepository(ISkillLevelContext context)
        {
            _Context = context;
        }

        public SkillLevel GetById(int Id)
        {
            return DTOModelConverter.SkillLevelDTOToModel(_Context.GetById(Id));
        }
    }
}
