using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using DataAcces.DTOs;
using DataAcces.Interfaces;
using GymnasticRoutineDesigner.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymnasticRoutineDesigner.Controllers
{
    public class SkillGroupController : Controller
    {
        private readonly SkillGroupRepository _Repo;
        private readonly ISkillGroupContext _Context;
        public SkillGroupController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetSkillGroupsFromApparatus(ApparatusViewModel avm)
        {
            IReadOnlyList<SkillGroup> skillGroups = _Repo.GetSkillGroupsFromApparatus(new ApparatusDTO(avm.Id, avm.Name, avm.Abbreviation));
            return View();
        }
    }
}