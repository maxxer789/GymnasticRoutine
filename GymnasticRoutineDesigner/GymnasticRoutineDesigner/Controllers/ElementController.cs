using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using DataAcces.Contexts;
using DataAcces.DTOs;
using DataAcces.Interfaces;
using GymnasticRoutineDesigner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GymnasticRoutineDesigner.Controllers
{
    public class ElementController : Controller
    {
        private readonly ElementRepository _Repo;
        private readonly IElementContext _Context;

        public ElementController(IConfiguration config)
        {
            _Context = new ElementContext(config.GetConnectionString("DefaultConnection"));
            _Repo = new ElementRepository(_Context);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetElementsFromSkillGroup(SkillGroupViewModel sgvm)
        {
            IReadOnlyList<Element> elements = _Repo.GetAllElementsFromSkillGroup(new SkillGroupDTO(sgvm.Id, new ApparatusDTO(sgvm.Apparatus.Id, sgvm.Apparatus.Name, sgvm.Apparatus.Abbreviation), sgvm.Name));
            return View("ElementOverview", elements);
        }
    }
}