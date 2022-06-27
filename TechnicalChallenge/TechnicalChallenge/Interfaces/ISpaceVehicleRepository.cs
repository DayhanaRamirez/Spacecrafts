using TechnicalChallenge.Models;

namespace TechnicalChallenge.Interfaces
{
    public interface ISpaceVehicleRepository
    {
        Task Create(string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType);
        Task Delete(int id);
        Task<List<SpaceVehicle>> GetAll();
        Task<List<SpaceVehicle>> GetByCountry(string country);
        Task<List<SpaceVehicle>> GetByFuel(string fuel);
        Task<SpaceVehicle> GetById(int id);
        Task<List<SpaceVehicle>> GetByIsActive();
        Task<List<SpaceVehicle>> GetByName(string name);
        Task<List<SpaceVehicle>> GetByPush(double push);
        Task<List<SpaceVehicle>> GetBySpeed(double speed);
        Task<List<SpaceVehicle>> GetByWeight(double weight);
        Task Update(int id, string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType);
    }
}