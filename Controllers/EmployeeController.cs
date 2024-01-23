using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using firstapi.Models;
using firstapi.Service;

namespace firstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpServ<Employee> _empserv;

        public EmployeeController(IEmpServ<Employee> empserv)
        {
            _empserv=empserv;
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return _empserv.GetAllEmployees(); 
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = _empserv.GetEmpById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // PUT: api/Employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.Eid)
            {
                return BadRequest();
            }

           // _context.Entry(employee).State = EntityState.Modified;
        try
        {
          _empserv.UpdateEmployee(id,employee);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            
            try
            {
            _empserv.AddEmployee(employee);
            }
            catch (DbUpdateException)
            {
                if (EmployeeExists(employee.Eid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployee", new { id = employee.Eid }, employee);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = _empserv.GetEmpById(id);
            if (employee == null)
            {
                return NotFound();
            }

            _empserv.DeleteEmployee(id);
            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            Employee e= _empserv.GetEmpById(id);
            if(e!=null)
            return true;
            else
            return false;
        }
    }
}
