using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRCore.Staff.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TeamController(ITeamRepository teamRepository, IUnitOfWork unitOfWork)
        {
            _teamRepository = teamRepository;
            _unitOfWork = unitOfWork;
        }


        // GET api/team
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return _teamRepository.GetAll();
        }

        // GET api/teams/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return _teamRepository.GetById(id);
        }

        // POST api/teams
        [HttpPost]
        public IActionResult Post([FromBody]Team team)
        {
            if (team == null)
            {
                return BadRequest();
            }

            _teamRepository.Insert(team);
            _unitOfWork.Commit();

            return Ok(team);
        }

        // PUT api/teams/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Team team)
        {
            if (team == null || team.TeamId != id)
                return BadRequest();


            _teamRepository.Update(team);
            _unitOfWork.Commit();
            return Ok(team);
        }

        // DELETE api/teams/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _teamRepository.Delete(id);
            _unitOfWork.Commit();

            return new NoContentResult();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        }
    }
