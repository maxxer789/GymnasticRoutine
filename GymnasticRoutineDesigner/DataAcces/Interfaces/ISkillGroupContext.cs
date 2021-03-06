﻿using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface ISkillGroupContext
    {
        IReadOnlyList<SkillGroupDTO> GetAll();

        SkillGroupDTO GetElementsBySkillGroup(int Id);

    }
}
