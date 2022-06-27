using TechnicalChallenge.Models;

namespace TechnicalChallenge.Interfaces
{
    public interface IAstronautRepository
    {
        Task Create(string name, string country, int age, string sex, double weight, bool isActive, int idCrew);
        Task Delete(int id);
        Task<List<Astronaut>> GetAll();
        Task<Astronaut> GetById(int id);
        Task Update(int id, string name, string country, int age, string sex, double weight, bool isActive, int idCrew);
    }
}