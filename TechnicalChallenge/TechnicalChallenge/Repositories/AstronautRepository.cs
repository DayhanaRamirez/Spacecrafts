using Microsoft.EntityFrameworkCore;
using TechnicalChallenge.Data;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Repositories
{
    //Repository for astronauts. Here is where I connect to my DB with the data recevied, do crud
    //functions in the DB and save changes. 
    public class AstronautRepository : IAstronautRepository
    {
        private readonly TechnicalChallengeDbContext _context;

        public AstronautRepository(TechnicalChallengeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Astronaut>> GetAll()
        {
            return await _context.Astronauts.ToListAsync();
        }

        public async Task<Astronaut> GetById(int id)
        {
            return await _context.Astronauts.FindAsync(id);
        }

        public async Task Create(string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            Astronaut astronaut = new()
            {
                Name = name,
                Country = country,
                Age = age,
                Sex = sex,
                Weight = weight,
                IsActive = isActive,
                IdCrew = idCrew
            };

            _context.Add(astronaut);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, string name, string country, int age, string sex, double weight, bool isActive, int idCrew)
        {
            var astronaut = await _context.Astronauts.FindAsync(id);
            astronaut.Name = name;
            astronaut.Country = country;
            astronaut.Age = age;
            astronaut.Sex = sex;
            astronaut.Weight = weight;
            astronaut.IsActive = isActive;
            astronaut.IdCrew = idCrew;
            _context.Update(astronaut);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var astronaut = await _context.Astronauts.FindAsync(id);
            _context.Astronauts.Remove(astronaut);
            await _context.SaveChangesAsync();
        }

    }
}
