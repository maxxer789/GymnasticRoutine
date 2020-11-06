using BusinessLogic.Models;
using BusinessLogic.Models.Converter;
using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BusinessLogic.Repositories
{
    public class SkillGroupRepository
    {
        private ISkillGroupContext _Context;
        public SkillGroupRepository(ISkillGroupContext context)
        {
            _Context = context;
        }
        public IReadOnlyList<SkillGroup> GetAll()
        {
            return DTOModelConverter.SkillGroupDTOToModel(_Context.GetAll().ToList());
        }
    }
}
