using TechnicalChallenge.Models;

namespace TechnicalChallenge.Interfaces
{
    public interface IAstronautServices
    {
        Task CreateAstronaut(string name, string country, int age, string sex, double weight, bool isActive, int idCrew);
        Task DeleteAstronaut(int id);
        Task<List<Astronaut>> GetAllAstronauts();
        Task<Astronaut> GetAstronaut(int id);
        Task UpdateAstronaut(int id, string name, string country, int age, string sex, double weight, bool isActive, int idCrew);
    }
}