using System;
using System.Collections.Generic;
using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;
using Microsoft.AspNetCore.Mvc;


namespace HRCore.Staff.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller, IDisposable
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }


        // GET api/employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAll();
        }

        // GET api/employees/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeRepository.GetById(id);
        }

        // POST api/employees
        [HttpPost]
        public IActionResult Post([FromBody]Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            _employeeRepository.Insert(employee);
            _unitOfWork.Commit();

            return Ok(employee);
        }

        // PUT api/employees/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee employee)
        {
            if (employee == null || employee.EmployeeId != id)
                return BadRequest();


            _employeeRepository.Update(employee);
            _unitOfWork.Commit();
            return Ok(employee);
        }

        // DELETE api/employees/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _employeeRepository.Delete(id);
            _unitOfWork.Commit();

            return new NoContentResult();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
