using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartGrid.API.Servicios.Definiciones;
using SmartGrid.Datos.DTO;

namespace SmartGrid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartGridAPIController : ControllerBase
    {
        private readonly ILogger<SmartGridAPIController> _logger;
        private IServicePersonType _servicePersonType { get; set; }
        private IServicePerson _servicePerson { get; set; }
        public SmartGridAPIController(ILogger<SmartGridAPIController> logger, IServicePersonType servicePersonType, IServicePerson servicePerson)
        {
            _logger = logger;
            _servicePersonType = servicePersonType;
            _servicePerson = servicePerson;
        }
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("SmartGrid API 1.0");
        }
        [HttpGet("Person")]
        public IActionResult GetPersons()
        {
            return Ok(_servicePerson.Get());
        }

        [HttpPost("Person")]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            return Ok(_servicePerson.Create(person));
        }

        [HttpPut("Person/{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] Person person)
        {

            return Ok(_servicePerson.Update(id, person));
        }

        [HttpDelete("Person/{id}")]
        public IActionResult DeletePerson(int id)
        {
            return Ok(_servicePerson.Delete(id));
        }

        [HttpGet("PersonType")]
        public IActionResult GetPersonTypes()
        {
            return Ok(_servicePersonType.Get());
        }

        [HttpPost("PersonType")]
        public IActionResult CreatePersonType([FromBody] PersonType personType)
        {
            return Ok(_servicePersonType.Create(personType));
        }

        [HttpPut("PersonType/{id}")]
        public IActionResult UpdatePersonType(int id, [FromBody] PersonType personType)
        {

            return Ok(_servicePersonType.Update(id, personType));
        }

        [HttpDelete("PersonType/{id}")]
        public IActionResult DeletePersonType(int id)
        {
            return Ok(_servicePersonType.Delete(id));
        }
    }
}
