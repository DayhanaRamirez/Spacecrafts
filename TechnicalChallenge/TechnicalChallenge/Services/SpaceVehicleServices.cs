using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Services
{
    public class SpaceVehicleServices : ISpaceVehicleServices
    {
        private readonly ISpaceVehicleRepository _spaceVehicleRepository;

        public SpaceVehicleServices(ISpaceVehicleRepository spaceVehicleRepository)
        {
            _spaceVehicleRepository = spaceVehicleRepository;
        }
        public async Task<List<SpaceVehicle>> GetAllSpaceVehicles()
        {
            var spaceVehicles = await _spaceVehicleRepository.GetAll();
            return spaceVehicles;
        }

        public async Task<SpaceVehicle> GetSpaceVehicle(int id)
        {
            var spaceVehicle = await _spaceVehicleRepository.GetById(id);
            return spaceVehicle;
        }

        public async Task CreateSpaceVehicle(string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            await _spaceVehicleRepository.Create(name, country, speed, weight, push, fuel, isActive, idType);
        }

        public async Task UpdateSpaceVehicle(int id, string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            await _spaceVehicleRepository.Update(id, name, country, speed, weight, push, fuel, isActive, idType);
        }

        public async Task DeleteSpaceVehicle(int id)
        {
            await _spaceVehicleRepository.Delete(id);
        }

        public async Task<List<SpaceVehicle>> GetByName(string name)
        {
            return await _spaceVehicleRepository.GetByName(name);
        }


        public async Task<List<SpaceVehicle>> GetByCountry(string country)
        {
            return await _spaceVehicleRepository.GetByCountry(country);
        }

        public async Task<List<SpaceVehicle>> GetBySpeed(double speed)
        {
            return await _spaceVehicleRepository.GetBySpeed(speed);
        }

        public async Task<List<SpaceVehicle>> GetByWeight(double weight)
        {
            return await _spaceVehicleRepository.GetByWeight(weight);
        }

        public async Task<List<SpaceVehicle>> GetByPush(double push)
        {
            return await _spaceVehicleRepository.GetByPush(push);
        }

        public async Task<List<SpaceVehicle>> GetByFuel(string fuel)
        {
            return await _spaceVehicleRepository.GetByFuel(fuel);
        }

        public async Task<List<SpaceVehicle>> GetByIsActive()
        {
            return await _spaceVehicleRepository.GetByIsActive();
        }

    }
}
