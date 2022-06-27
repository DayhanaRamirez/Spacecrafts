using Microsoft.EntityFrameworkCore;
using System.Linq;
using TechnicalChallenge.Data;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

namespace TechnicalChallenge.Repositories
{
    //Repository for space vehicles. Here is where I connect to my DB with the data recevied, do crud
    //functions in the DB and save changes. 
    public class SpaceVehicleRepository : ISpaceVehicleRepository
    {
        private readonly TechnicalChallengeDbContext _context;

        public SpaceVehicleRepository(TechnicalChallengeDbContext context)
        {
            _context = context;
        }

        public async Task<List<SpaceVehicle>> GetAll()
        {
            return await _context.SpaceVehicles.ToListAsync();
        }

        public async Task<SpaceVehicle> GetById(int id)
        {
            return await _context.SpaceVehicles.FindAsync(id);
        }

        public async Task Create(string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            SpaceVehicle spaceVehicle = new()
            {
                Name = name,
                Country = country,
                Speed = speed,
                Weight = weight,
                Push = push,
                Fuel = fuel,
                IsActive = isActive,
                IdType = idType,
            };

            _context.Add(spaceVehicle);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, string name, string country, double speed, double weight, double push, string fuel, bool isActive, int idType)
        {
            var spaceVehicle = await _context.SpaceVehicles.FindAsync(id);
            spaceVehicle.Name = name;
            spaceVehicle.Country = country;
            spaceVehicle.Speed = speed;
            spaceVehicle.Weight = weight;
            spaceVehicle.Push = push;
            spaceVehicle.Fuel = fuel;
            spaceVehicle.IsActive = isActive;
            spaceVehicle.IdType = idType;
            _context.Update(spaceVehicle);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var spaceVehicle = await _context.SpaceVehicles.FindAsync(id);
            _context.SpaceVehicles.Remove(spaceVehicle);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SpaceVehicle>> GetByName(string name)
        {
            return await _context.SpaceVehicles.Where(x => x.Name == name).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetByCountry(string country)
        {
            return await _context.SpaceVehicles.Where(x => x.Country == country).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetBySpeed(double speed)
        {
            return await _context.SpaceVehicles.Where(x => x.Speed == speed).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetByWeight(double weight)
        {
            return await _context.SpaceVehicles.Where(x => x.Weight == weight).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetByPush(double push)
        {
            return await _context.SpaceVehicles.Where(x => x.Push == push).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetByFuel(string fuel)
        {
            return await _context.SpaceVehicles.Where(x => x.Fuel == fuel).ToListAsync();
        }

        public async Task<List<SpaceVehicle>> GetByIsActive()
        {
            return await _context.SpaceVehicles.Where(x => x.IsActive == true).ToListAsync();
        }
    }
}
