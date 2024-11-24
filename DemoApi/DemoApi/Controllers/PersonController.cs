using Microsoft.AspNetCore.Mvc;
using MongoDemoData.Data.Models;
using MongoDemoData.Repository;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var persons = await _personRepository.GetAllPersons();
            return Ok(persons);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var person = await _personRepository.GetPersonById(id);
            if (person is null){
                return NotFound();
            }
            return Ok(person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> Post(Person person)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data");
            var result = await _personRepository.AddPerson(person);
            if (!result)
                return BadRequest("Could not save data");
            return Ok(result);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Person newPerson)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data");
            var person = await _personRepository.GetPersonById(id);
            if (person is null)
                return NotFound();
            newPerson.Id = id;
            var result = await _personRepository.UpdatePerson(newPerson);
            if (!result)
                return BadRequest("Could not save data");
            return Ok(result);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var person = await _personRepository.GetPersonById(id);
            if (person is null)
                return NotFound();
            var result = await _personRepository.DeletePerson(id);
            if (!result)
                return BadRequest("Could not delete data");
            return Ok(result);
        }
    }
}
