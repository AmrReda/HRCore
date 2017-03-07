using System.Collections.Generic; 
using HRCore.Staff.DAL;
using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRCore.Staff.Controllers
{
    [Route("api/[controller]")]
    public class OfficeController : Controller
    {
        private readonly IOfficeRepository _officeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OfficeController(IOfficeRepository officeRepository, IUnitOfWork unitOfWork)
        {
            _officeRepository = officeRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: api/office
        [HttpGet]
        public IEnumerable<Office> Get()
        {
            return _officeRepository.GetAll();
        }

        // GET api/office/5
        [HttpGet("{id}")]
        public Office Get(int id)
        {
            return _officeRepository.GetById(id);
        }

        // POST api/office
        [HttpPost]
        public IActionResult Post([FromBody]Office office)
        {
            if (office == null)
            {
                return BadRequest();
            }

            _officeRepository.Insert(office);
            _unitOfWork.Commit();

            return Ok(office);
        }

        // PUT api/office/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Office office)
        {
            if (office == null || office.OfficeId != id)
                return BadRequest();


            _officeRepository.Update(office);
            _unitOfWork.Commit();
            return Ok(office);
        }

        // DELETE api/office/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _officeRepository.Delete(id);
            _unitOfWork.Commit();

            return new NoContentResult();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
