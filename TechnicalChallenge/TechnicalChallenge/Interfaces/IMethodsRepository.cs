using TechnicalChallenge.Models;

namespace TechnicalChallenge.Interfaces
{
    public interface IMethodsRepository
    {
        Task<Astronaut> GetAstronautById(int id);
        Task<AstronomicalObject> GetAstronomicalObjectById(int id);
        Task<Cargo> GetCargoById(int id);
        Task<Crew> GetCrewById(int id);
        Task<SpaceVehicle> GetSpaceVehicleById(int id);
        Task<SpaceVehicleType> GetSpaceVehicleTypeById(int id);
    }
}