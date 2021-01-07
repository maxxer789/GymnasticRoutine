﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Repositories;
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

        public RoutineController(IRoutineContext _Context)
        {
            _Repo = new RoutineRepository(_Context);
        }
        
        [HttpGet]
        [Route("byId/{Id}"), ActionName("routineById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
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
                RoutineViewModel element = ViewModelConverter.RoutineToViewModel(_Repo.GetById(Id));
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
                RoutineViewModel createdRoutine = ViewModelConverter.RoutineToViewModel(_Repo.Create(ViewModelConverter.ViewModelToRoutine(rcvm)));
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
