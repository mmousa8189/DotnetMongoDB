using DotnetMongoDB.API.Models;
using DotnetMongoDB.API.Repository;
using DotnetMongoDB.API.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetMongoDB.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly IMongoRepository<Person> _peopleRepository;
        public SampleController(IMongoRepository<Person> peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        [HttpPost("registerPerson")]
        public async Task AddPerson(string firstName, string lastName)
        {
            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName
            };

            await _peopleRepository.InsertOneAsync(person);
        }

        [HttpGet("getPeopleData")]
        public IEnumerable<string> GetPeopleData()
        {
            var people = _peopleRepository.FilterBy(
                filter => filter.FirstName != "test",
                projection => projection.FirstName
            );
            return people;
        }

        [HttpPost("addCustomer")]
        public IActionResult Add(CustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

                // re-render the view when validation failed.
                //return View(model);
            }

            //TODO: Save the data to the database, or some other logic.

            return Ok();
        }
        // Manual validation
        [HttpPut("updateCustomer")]
        public IActionResult Update(CustomerModel model)
        {
            CustomerValidator validator = new CustomerValidator();
            var validationResult = validator.Validate(model);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            //TODO: Save the data to the database, or some other logic.

            return Ok();
        }
    }
}
