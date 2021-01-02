using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using DataAcces.Contexts;
using DataAcces.Interfaces;
using GymnasticRoutineDesigner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutineDesginerAPI.Models;
using RoutineDesginerAPI.Models.ViewModelConverter;

namespace RoutineDesginerAPI.Controllers
{
    //api/element
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        private readonly ElementRepository _Repo;

        public ElementController(IElementContext _IContext)
        {
            _Repo = new ElementRepository(_IContext);
        }

        [HttpGet]
        [Route("byId/{Id}"), ActionName("elementById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetElementById(int Id)
        {
            try
            {
                if (Id <= 0)
                {
                    return BadRequest("Request doesn't pass validation");
                }
                ElementViewModel element = ViewModelConverter.ElementToViewModel(_Repo.GetById(Id));
                if (element == null)
                {
                    return NotFound();
                }
                return Ok(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        [Route("create"), ActionName("createElement")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateElement([FromBody] ElementCreateViewModel ecvm)
        {
            try
            {
                if (ecvm == null)
                {
                    return BadRequest("Empty body");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Request doesn't pass validation");
                }
                ElementViewModel createdElement = ViewModelConverter.ElementToViewModel(_Repo.Create(new Element { Name = ecvm.Name, Difficulty = ecvm.Difficulty, Priority = ecvm.Priority, SkillGroupId = ecvm.SkillGroupId, Worth = ecvm.Worth }));
                return CreatedAtAction("elementById", new { id = createdElement.Id }, createdElement);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
