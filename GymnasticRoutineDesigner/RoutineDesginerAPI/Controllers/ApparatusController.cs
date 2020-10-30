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
    [Route("api/[controller]")]
    [ApiController]
    public class ApparatusController : ControllerBase
    {
        private readonly ApparatusRepository _Repo;

        private readonly IApparatusContext _Icontext;

        public ApparatusController()
        {
            _Icontext = new ApparatusContext();
            _Repo = new ApparatusRepository(_Icontext);
        }

        // GET: api/Apparatus
        [HttpGet]
        [Route("all"), ActionName("apparatusOverview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllApparatus()
        {
            List<ApparatusViewModel> apparatus = new List<ApparatusViewModel>();
            try
            {
                foreach (Apparatus app in _Repo.GetAllApparatus())
                {
                    List<SkillGroupViewModel> sgvms = new List<SkillGroupViewModel>();

                    foreach(SkillGroup sg in app.SkillGroups)
                    {
                        List<ElementViewModel> evms = new List<ElementViewModel>();

                        foreach(Element e in sg.Elements)
                        {
                            evms.Add(new ElementViewModel(e.Id, e.Priority, e.Name, e.Difficulty, e.Worth));
                        }

                        sgvms.Add(new SkillGroupViewModel(sg.Id, sg.Name, evms));
                    }

                    apparatus.Add(new ApparatusViewModel(app.Id, app.Name, app.Abbreviation, sgvms));
                }

                return Ok(apparatus.AsReadOnly());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
