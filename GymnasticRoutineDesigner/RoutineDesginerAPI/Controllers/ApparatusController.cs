using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAcces.Contexts;
using DataAcces.DTOs;
using BusinessLogic.Repositories;
using DataAcces.Interfaces;
using BusinessLogic.Models;
using GymnasticRoutineDesigner.Models;
using RoutineDesginerAPI.Models.ViewModelConverter;

namespace RoutineDesginerAPI.Controllers
{
    // api/Apparatus
    [Route("api/[controller]")]
    [ApiController]
    public class ApparatusController : ControllerBase
    {
        private readonly ApparatusRepository _Repo;

        private readonly IApparatusContext _Context;

        public ApparatusController()
        {
            _Context = new ApparatusContext();
            _Repo = new ApparatusRepository(_Context);
        }

        [HttpGet]
        [Route("all"), ActionName("apparatusOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllApparatus()
        {
            try
            {
                List<ApparatusViewModel> apparatus = ViewModelConverter.ApparatusToViewModel(_Repo.GetAll().ToList());
                
                return Ok(apparatus.AsReadOnly());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("{Id}"), ActionName("ApparatusById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetApparatusById(int Id)
        {
            try
            {
                ApparatusViewModel app = ViewModelConverter.ApparatusToViewModel(_Repo.GetById(Id));
                return Ok(app);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("{Id}/skillGroups"), ActionName("SkillGroupsFromApparatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetSkillGroupsFromApparatus(int Id)
        {
            try
            {
                ApparatusViewModel app = ViewModelConverter.ApparatusToViewModel(_Repo.GetSkillGroups(Id));
                return Ok(app);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
