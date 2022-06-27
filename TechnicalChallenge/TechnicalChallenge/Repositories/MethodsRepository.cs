using TechnicalChallenge.Data;
using TechnicalChallenge.Models;
using Microsoft.EntityFrameworkCore;
using TechnicalChallenge.Interfaces;

namespace TechnicalChallenge.Repositories
{
    //Repository for methods. Here is where I connect to my DB to find objects to know info about them.
    public class MethodsRepository : IMethodsRepository
    {
        private readonly TechnicalChallengeDbContext _context;

        public MethodsRepository(TechnicalChallengeDbContext context)
        {
            _context = context;
        }

        public async Task<Astronaut> GetAstronautById(int id)
        {
            return await _context.Astronauts.FindAsync(id);
        }

        public async Task<AstronomicalObject> GetAstronomicalObjectById(int id)
        {
            return await _context.AstronomicalObjects.FindAsync(id);
        }

        public async Task<Cargo> GetCargoById(int id)
        {
            return await _context.Cargos.FindAsync(id);
        }

        public async Task<Crew> GetCrewById(int id)
        {
            return await _context.Crews.FindAsync(id);
        }

        public async Task<SpaceVehicle> GetSpaceVehicleById(int id)
        {
            return await _context.SpaceVehicles.FindAsync(id);
        }

        public async Task<SpaceVehicleType> GetSpaceVehicleTypeById(int id)
        {
            return await _context.SpaceVehicleTypes.FindAsync(id);
        }
    }
}
