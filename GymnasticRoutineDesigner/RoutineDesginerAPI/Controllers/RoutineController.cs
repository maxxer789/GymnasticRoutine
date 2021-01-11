using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Repositories;
using BusinessLogic.Models;
using DataAcces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutineDesginerAPI.Models;
using RoutineDesginerAPI.Models.ViewModelConverter;

namespace RoutineDesginerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutineController : ControllerBase
    {
        private readonly RoutineRepository _Repo;
        private readonly ApparatusRepository _AppRepo;
        private readonly SkillLevelRepository _SkLRepo;

        public RoutineController(IRoutineContext _Context, IApparatusContext _AppContext, ISkillLevelContext _SkLContext)
        {
            _Repo = new RoutineRepository(_Context);
            _AppRepo = new ApparatusRepository(_AppContext);
            _SkLRepo = new SkillLevelRepository(_SkLContext);
        }
        
        [HttpGet]
        [Route("{Id}"), ActionName("routineById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetRoutineById(int Id)
        {
            try
            {
                if (Id <= 0)
                {
                    return BadRequest("Request doesn't pass validation");
                }
                RoutineViewModel routine = ViewModelConverter.RoutineToViewModel(_Repo.GetById(Id));

                if (routine == null)
                {
                    return NotFound();
                }

                return Ok(routine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        [Route("create"), ActionName("createRoutine")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateRoutine([FromBody] RoutineCreateViewModel rcvm)
        {
            try
            {
                if (rcvm == null)
                {
                    return BadRequest("Empty body");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Request doesn't pass validation");
                }
                
                RoutineViewModel createdRoutine = ViewModelConverter.RoutineToViewModel(_Repo.Create(new Routine(rcvm.Name, _AppRepo.GetById(rcvm.ApparatusId), _SkLRepo.GetById(rcvm.SkillLevelId))));

                if (createdRoutine.Id > 0)
                {
                    return CreatedAtAction("routineById", new { Id = createdRoutine.Id }, createdRoutine);
                }
                else
                {
                    return BadRequest("Routine name cannot be empty and must be longer than 5 characters");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
