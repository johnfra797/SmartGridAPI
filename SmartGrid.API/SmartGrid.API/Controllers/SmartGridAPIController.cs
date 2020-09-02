using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SmartGrid.API.Servicios.Definiciones;
using SmartGrid.Datos.DTO;

namespace SmartGrid.API.Controllers
{
    ///<summary>
    ///Controlador SmartGridAPIController
    ///</summary>
    ///<remarks>
    ///Se usa como punto de entrada al API implementado las clases de servicio de cada objeto (person y personType)
    ///Tambien se implementa la interface de ILogger para poder guardar logs de ser necesario.
    ///</remarks>
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

        [HttpGet("Person/{id}")]
        public IActionResult GetPersons(int id)
        {
            return Ok(_servicePerson.Get(id));
        }

        [HttpPost("Person")]
        public IActionResult CreatePerson([FromBody] JsonElement body)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(body);
            Person person = JsonConvert.DeserializeObject<Person>(json);
            return Ok(_servicePerson.Create(person));
        }

        [HttpPut("Person/{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] JsonElement body)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(body);
            Person person = JsonConvert.DeserializeObject<Person>(json);

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
        [HttpGet("PersonType/{id}")]
        public IActionResult GetPersonTypes(int id)
        {
            return Ok(_servicePersonType.Get(id));
        }
        [HttpPost("PersonType")]
        public IActionResult CreatePersonType([FromBody] JsonElement body)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(body);
            PersonType personType = JsonConvert.DeserializeObject<PersonType>(json);
            return Ok(_servicePersonType.Create(personType));
        }

        [HttpPut("PersonType/{id}")]
        public IActionResult UpdatePersonType(int id, [FromBody] JsonElement body)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(body);
            PersonType personType = JsonConvert.DeserializeObject<PersonType>(json);

            return Ok(_servicePersonType.Update(id, personType));
        }

        [HttpDelete("PersonType/{id}")]
        public IActionResult DeletePersonType(int id)
        {
            return Ok(_servicePersonType.Delete(id));
        }
    }
}
