using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalChallenge.Controllers;
using TechnicalChallenge.Interfaces;

namespace TechnicalChallengeTest.MethodTest
{
    public class MethodControllerTest
    {
        private readonly Mock<IMethodsServices> _mockMethodsServices;
        private readonly MethodsController _methodsController;

        public MethodControllerTest()
        {
            _mockMethodsServices = new Mock<IMethodsServices>();
            _methodsController = new MethodsController(_mockMethodsServices.Object);
        }

        [Fact]
        public void Recupera_Astronauta_Correctamente()
        {
            var txt = "I'm Daniel. I am an astronaut, a person trained, equipped, and deployed by a human spaceflight program to serve as a commander or crew member aboard a spacecraft."
                + "I work 10 hours per day.";

            Task<string> res = Task<string>.Factory.StartNew(() =>
            {
                return txt;
            });

            var _methodsController = new MethodsController(_mockMethodsServices.Object);

            _mockMethodsServices.Setup(x => x.GetAstronaut(1)).Returns(res);
            var astronauta = _methodsController.GetAstronaut(1);
            Assert.Equal(txt, astronauta.Result);
        }

        [Fact]
        public void Recupera_AstronomicalObject_Correctamente()
        {

            var txt = "I'm Moon. I am an astronomical object, a naturally occurring physical entity, association, or structure that exists in the observable universe."
                + "I work the same hours as my space vehicle.";

            Task<string> res = Task<string>.Factory.StartNew(() =>
            {
                return txt;
            });

            var _methodsController = new MethodsController(_mockMethodsServices.Object);

            _mockMethodsServices.Setup(x => x.GetAstronomicalObject(1)).Returns(res);
            var astronomicalObject = _methodsController.GetAstronomicalObject(1);
            Assert.Equal(txt, astronomicalObject.Result);

        }
    }
}
