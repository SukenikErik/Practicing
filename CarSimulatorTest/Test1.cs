using CarSimulator.Model;
using CarSimulator.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace CarSimulatorTest
{
    [TestClass]
    public class CarSimulatorTests
    {
        [TestMethod]
        public void Airbags_Open_When_Speed_Is_High_And_Seat_IsOccupied()
        {
            var seat1 = new Seat(true);
            var seat2 = new Seat(false);
            var car = new Car(100, new[] { seat1, seat2 });

            var simulator = new CarSimulator.Service.CarSimulator(80);

            simulator.SimulateCrash(car);

            Assert.IsTrue(seat1.AirbagOpened);
            Assert.IsFalse(seat2.AirbagOpened);
        }

        [TestMethod]
        public void Airbags_DoNot_Open_When_Speed_Is_Too_Low()
        {
            var seat1 = new Seat(true);
            var seat2 = new Seat(true);
            var car = new Car(50, new[] { seat1, seat2 });

            var simulator = new CarSimulator.Service.CarSimulator(80);

            simulator.SimulateCrash(car);

            Assert.IsFalse(seat1.AirbagOpened);
            Assert.IsFalse(seat2.AirbagOpened);
        }

        [TestMethod]
        public void Seats_Are_Not_Duplicated_In_Car()
        {
            var seat = new Seat(true);
            var car = new Car(90, new[] { seat, seat });

            Assert.AreEqual(1, car.Seats.Count);
        }

        [TestMethod]
        public void Airbag_Only_Opens_If_Seat_Is_Occupied()
        {
            var seat = new Seat(false);
            var car = new Car(100, new[] { seat });

            var simulator = new CarSimulator.Service.CarSimulator(90);
            simulator.SimulateCrash(car);

            Assert.IsFalse(seat.AirbagOpened);
        }
    }
}
