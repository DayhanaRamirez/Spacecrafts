using Microsoft.AspNetCore.Mvc;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Services
{
    //Services for astronauts. Here is where I call the repository to do crud functions and send data
    //taken from controller. 
    public class AstronautServices : IAstronautServices
    {
        private readonly IAstronautRepository _astronautRepository;

        public AstronautServices(IAstronautRepository astronautRepository)
        {
            _astronautRepository = astronautRepository;
        }

        public async Task<List<Astronaut>> GetAllAstronauts()
        {
            var astronauts = await _astronautRepository.GetAll();
            return astronauts;
        }

        public async Task<Astronaut> GetAstronaut(int id)
        {
            var astronaut = await _astronautRepository.GetById(id);
            return astronaut;
        }

        public async Task CreateAstronaut(string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            await _astronautRepository.Create(name, country, age, sex, weight, isActive, idCrew);
        }

        public async Task UpdateAstronaut(int id, string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            await _astronautRepository.Update(id, name, country, age, sex, weight, isActive, idCrew);
        }

        public async Task DeleteAstronaut(int id)
        {
            await _astronautRepository.Delete(id);
        }

    }
}
