using Microsoft.AspNetCore.Mvc;
using TechnicalChallenge.Interfaces;

namespace TechnicalChallenge.Controllers
{
    public class MethodsController : Controller
    {

        private readonly IMethodsServices _methodsServices;

        public MethodsController(IMethodsServices methodsServices)
        {
            _methodsServices = methodsServices;
        }

        [HttpGet]
        [Route("Methods/Astronaut")]
        public async Task<string> GetAstronaut(int id)
        {
            return await _methodsServices.GetAstronaut(id);
        }

        [HttpGet]
        [Route("Methods/AstronomicalObject")]
        public async Task<string> GetAstronomicalObject(int id)
        {
            return await _methodsServices.GetAstronomicalObject(id);
        }

        [HttpGet]
        [Route("Methods/Cargo")]
        public async Task<string> GetCargo(int id)
        {
            return await _methodsServices.GetCargo(id);
        }

        [HttpGet]
        [Route("Methods/Crew")]
        public async Task<string> GetCrew(int id)
        {
            return await _methodsServices.GetCrew(id);
        }

        [HttpGet]
        [Route("Methods/SpaceVehicle")]
        public async Task<string> GetSpaceVehicle(int id)
        {
            return await _methodsServices.GetSpaceVehicle(id);
        }

        [HttpGet]
        [Route("Methods/SpaceVehicleType")]
        public async Task<string> GetSpaceVehicleType(int id)
        {
            return await _methodsServices.GetSpaceVehicleType(id);
        }

    }
}
