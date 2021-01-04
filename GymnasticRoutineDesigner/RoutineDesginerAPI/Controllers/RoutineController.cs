using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Repositories;
using DataAcces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutineDesginerAPI.Models;

namespace RoutineDesginerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutineController : ControllerBase
    {
        private readonly RoutineRepository _Repo;

        public RoutineController(IRoutineContext _Context)
        {
            _Repo = new RoutineRepository(_Context);
        }

        [HttpPost]
        [Route("create"), ActionName("createRoutine")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateRoutine([FromBody] RoutineCreateViewModel rcvm)
        {
            return Ok();
        }
    }
}
