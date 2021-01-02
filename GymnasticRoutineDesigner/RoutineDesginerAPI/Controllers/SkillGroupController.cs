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
    //api/skillgroup
    [Route("api/[controller]")]
    [ApiController]
    public class SkillGroupController : ControllerBase
    {
        private readonly SkillGroupRepository _Repo;

        public SkillGroupController(ISkillGroupContext _Context)
        {
            _Repo = new SkillGroupRepository(_Context);
        }

        [HttpGet]
        [Route("all"), ActionName("skillGroupOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            try
            {
                List<SkillGroupViewModel> skillGroups = ViewModelConverter.SkillGroupToViewModel(_Repo.GetAll().ToList());
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
