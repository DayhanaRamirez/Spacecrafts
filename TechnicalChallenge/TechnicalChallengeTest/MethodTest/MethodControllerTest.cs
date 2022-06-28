using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalChallenge.Controllers;
using TechnicalChallenge.Interfaces;
using TechnicalChallenge.Models;

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

        //Testing abstract behaviour of objects
        [Fact]
        public void Recupera_Astronauta_Correctamente()
        {
            //Arrange
            var txt = "I'm Daniel. I am an astronaut, a person trained, equipped, and deployed by a human spaceflight program to serve as a commander or crew member aboard a spacecraft."
                + "I work 10 hours per day.";
            Astronaut mockAstronaut = new()
            {
                Name = "Daniel"
            };
            var txtExpected = mockAstronaut.SelfDescription() + mockAstronaut.ShiftLength();

            Task<string> res = Task<string>.Factory.StartNew(() =>
            {
                return txt;
            });

            _mockMethodsServices.Setup(x => x.GetAstronaut(1)).Returns(res);

            //Act
            var astronauta = _methodsController.GetAstronaut(1);

            //Assert
            Assert.Equal(txtExpected, astronauta.Result);
        }

        //Testing abstract behaviour of objects
        [Fact]
        public void Recupera_AstronomicalObject_Correctamente()
        {
            //Arrange
            var txt = "I'm Moon. I am an astronomical object, a naturally occurring physical entity, association, or structure that exists in the observable universe."
                + "I work the same hours as my space vehicle.";

            AstronomicalObject mockAstronomicalObject = new()
            {
                Name = "Moon"
            };

            var txtExpected = mockAstronomicalObject.SelfDescription() + mockAstronomicalObject.ShiftLength();
            
            Task<string> res = Task<string>.Factory.StartNew(() =>
            {
                return txt;
            });

            _mockMethodsServices.Setup(x => x.GetAstronomicalObject(1)).Returns(res);

            //Act
            var astronomicalObject = _methodsController.GetAstronomicalObject(1);

            //Assert
            Assert.Equal(txtExpected, astronomicalObject.Result);
        }
    }
}
