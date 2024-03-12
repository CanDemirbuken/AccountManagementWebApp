using AccountManagementWebApp.BusinessLayer.Abstract;
using AccountManagementWebApp.Core.DTOs.EmployeeDTO;
using AccountManagementWebApp.EntityLayer.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagementWebApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            var values = _employeeService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeAddDTO employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Employee>(employee);
            _employeeService.TAdd(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(EmployeeUpdateDTO employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Employee>(employee);
            _employeeService.TUpdate(values);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            _employeeService.TDelete(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            return Ok(values);
        }
    }
}
