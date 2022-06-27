using TechnicalChallenge.Models;

namespace TechnicalChallenge.Interfaces
{
    public interface ISpaceVehicleServices
    {
        Task CreateSpaceVehicle(string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType);
        Task DeleteSpaceVehicle(int id);
        Task<List<SpaceVehicle>> GetAllSpaceVehicles();
        Task<List<SpaceVehicle>> GetByCountry(string country);
        Task<List<SpaceVehicle>> GetByFuel(string fuel);
        Task<List<SpaceVehicle>> GetByIsActive();
        Task<List<SpaceVehicle>> GetByName(string name);
        Task<List<SpaceVehicle>> GetByPush(double push);
        Task<List<SpaceVehicle>> GetBySpeed(double speed);
        Task<List<SpaceVehicle>> GetByWeight(double weight);
        Task<SpaceVehicle> GetSpaceVehicle(int id);
        Task UpdateSpaceVehicle(int id, string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType);
    }
}