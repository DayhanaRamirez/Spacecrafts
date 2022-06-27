using Microsoft.AspNetCore.Mvc;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Controllers
{
    public class SpaceVehicleController : Controller
    {
        private readonly ISpaceVehicleServices _spaceVehiclesServices;

        public SpaceVehicleController(ISpaceVehicleServices spaceVehiclesServices)
        {
            _spaceVehiclesServices = spaceVehiclesServices;
        }

        [HttpGet]
        [Route("SpaceVehicle/GetAll")]
        public async Task<List<SpaceVehicle>> GetAll()
        {
            var astronauts = await _spaceVehiclesServices.GetAllSpaceVehicles();
            return astronauts;
        }

        [HttpGet]
        [Route("SpaceVehicleGetById")]
        public async Task<SpaceVehicle> GetById(int id)
        {
            var spaceVehicle = await _spaceVehiclesServices.GetSpaceVehicle(id);
            return spaceVehicle;
        }

        [HttpPost]
        [Route("SpaceVehicle/Create")]
        public async Task<string> Create(string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            await _spaceVehiclesServices.CreateSpaceVehicle(name, country, speed, weight, push, fuel, isActive, idType);
            return "SpaceVehicle has been created";
        }

        [HttpPut]
        [Route("SpaceVehicle/Update")]
        public async Task<string> Update(int id, string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            await _spaceVehiclesServices.UpdateSpaceVehicle(id, name, country, speed, weight, push, fuel, isActive, idType);
            return "SpaceVehicle has been updated";
        }

        [HttpDelete]
        [Route("SpaceVehicle/Delete")]
        public async Task<string> Update(int id)
        {
            await _spaceVehiclesServices.DeleteSpaceVehicle(id);
            return "SpaceVehicle has been deleted";
        }

        [HttpGet]
        [Route("SpaceVehicle/GetByName")]
        public async Task<List<SpaceVehicle>> GetByName(string name)
        {
            return await _spaceVehiclesServices.GetByName(name);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetByCountry")]
        public async Task<List<SpaceVehicle>> GetByCountry(string country)
        {
            return await _spaceVehiclesServices.GetByCountry(country);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetBySpeed")]
        public async Task<List<SpaceVehicle>> GetBySpeed(double speed)
        {
            return await _spaceVehiclesServices.GetBySpeed(speed);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetByWeight")]
        public async Task<List<SpaceVehicle>> GetByWeight(double weight)
        {
            return await _spaceVehiclesServices.GetByWeight(weight);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetByPush")]
        public async Task<List<SpaceVehicle>> GetByPush(double push)
        {
            return await _spaceVehiclesServices.GetByPush(push);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetByFuel")]
        public async Task<List<SpaceVehicle>> GetByFuel(string fuel)
        {
            return await _spaceVehiclesServices.GetByFuel(fuel);
        }


        [HttpGet]
        [Route("SpaceVehicle/GetByIsActive")]
        public async Task<List<SpaceVehicle>> GetByIsActive()
        {
            return await _spaceVehiclesServices.GetByIsActive();
        }





    }
}
