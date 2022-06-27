using TechnicalChallenge.Interfaces;

namespace TechnicalChallenge.Services
{
    public class MethodsServices : IMethodsServices
    {
        private readonly IMethodsRepository _methodsRepository;

        public MethodsServices(IMethodsRepository methodsRepository)
        {
            _methodsRepository = methodsRepository;
        }

        public async Task<string> GetAstronaut(int id)
        {
            var astronaut = await _methodsRepository.GetAstronautById(id);
            return $"{astronaut.SelfDescription()}" +
                   $" {astronaut.ShiftLength()}";
        }

        public async Task<string> GetAstronomicalObject(int id)
        {
            var astronomicalObject = await _methodsRepository.GetAstronomicalObjectById(id);
            return $"{astronomicalObject.SelfDescription()}" +
                   $" {astronomicalObject.ShiftLength()}";
        }

        public async Task<string> GetCargo(int id)
        {
            var cargo = await _methodsRepository.GetCargoById(id);
            return $"{cargo.SelfDescription()}" +
                   $" {cargo.ShiftLength()}";
        }

        public async Task<string> GetCrew(int id)
        {
            var crew = await _methodsRepository.GetCrewById(id);
            return $"{crew.SelfDescription()}" +
                   $" {crew.ShiftLength()}";
        }


        public async Task<string> GetSpaceVehicle(int id)
        {
            var spaceVehicle = await _methodsRepository.GetSpaceVehicleById(id);
            return $"{spaceVehicle.SelfDescription()}" +
                   $" {spaceVehicle.ShiftLength()}";
        }

        public async Task<string> GetSpaceVehicleType(int id)
        {
            var spaceVehicleType = await _methodsRepository.GetSpaceVehicleTypeById(id);
            return $"{spaceVehicleType.SelfDescription()}" +
                   $" {spaceVehicleType.ShiftLength()}";
        }
    }
}
