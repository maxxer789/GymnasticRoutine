using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Repositories;
using DataAcces.Contexts;
using DataAcces.Interfaces;
using GymnasticRoutineDesigner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutineDesginerAPI.Models.ViewModelConverter;

namespace RoutineDesginerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillGroupController : ControllerBase
    {
        private readonly SkillGroupRepository _Repo;

        private readonly ISkillGroupContext _Context;

        public SkillGroupController()
        {
            _Context = new SkillGroupContext();
            _Repo = new SkillGroupRepository(_Context);
        }

        // GET: api/SkillGroup
        [HttpGet]
        [Route("all"), ActionName("skillgroupOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllSkillgroups()
        {
            try
            {
                List<SkillGroupViewModel> skillGroups = ViewModelConverter.SkillGroupToViewModel(_Repo.GetAllSkillGroups().ToList());
                return Ok(skillGroups.AsReadOnly());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
