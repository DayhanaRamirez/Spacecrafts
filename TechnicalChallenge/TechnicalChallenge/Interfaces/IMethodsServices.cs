namespace TechnicalChallenge.Interfaces
{
    public interface IMethodsServices
    {
        Task<string> GetAstronaut(int id);
        Task<string> GetAstronomicalObject(int id);
        Task<string> GetCargo(int id);
        Task<string> GetCrew(int id);
        Task<string> GetSpaceVehicle(int id);
        Task<string> GetSpaceVehicleType(int id);
    }
}