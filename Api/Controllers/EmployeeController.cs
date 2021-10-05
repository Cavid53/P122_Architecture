using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Services.Interfaces;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class EmployeeController : CommonController
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<EmployeeDTO>> GetEmployees()
        {
            return Ok(_service.GetAllEmployees());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<EmployeeDTO> GetEmployee(int id)
        {
            return Ok(_service.GetEmployeeById(id));
        }
    }
}
