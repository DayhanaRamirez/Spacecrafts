using Microsoft.AspNetCore.Mvc;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Controllers
{

    //Controller for astronauts, where I send data to do crud functions to the services and then
    //retrieve it for the view. 

    public class AstronautController : Controller
    {
        private readonly IAstronautServices _astronautServices;

        public AstronautController(IAstronautServices astronautServices)
        {
            _astronautServices = astronautServices;
        }

        [HttpGet]
        [Route("Astronauts/GetAll")]
        public async Task<List<Astronaut>> GetAll()
        {
            var astronauts = await _astronautServices.GetAllAstronauts();
            return astronauts;
        }

        [HttpGet]
        [Route("Astronauts/GetById")]
        public async Task<Astronaut> GetById(int id)
        {
            var astronaut = await _astronautServices.GetAstronaut(id);
            return astronaut;
        }

        [HttpPost]
        [Route("Astronauts/Create")]
        public async Task<string> Create(string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            await _astronautServices.CreateAstronaut(name, country, age, sex, weight, isActive, idCrew);
            return "Astronaut has been created";
        }

        [HttpPut]
        [Route("Astronauts/Update")]
        public async Task<string> Update(int id, string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            await _astronautServices.UpdateAstronaut(id, name, country, age, sex, weight, isActive, idCrew);
            return "Astronaut has been updated";
        }

        [HttpDelete]
        [Route("Astronauts/Delete")]
        public async Task<string> Update(int id)
        {
            await _astronautServices.DeleteAstronaut(id);
            return "Astronaut has been deleted";
        }

    }
}
