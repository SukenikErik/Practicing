using CarSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    internal class Program
    {
        static void Main()
        {
            var seat1 = new Seat(true);
            var seat2 = new Seat(false);
            var car = new Car(90, new[] { seat1, seat2 });

            var simulator = new CarSimulator.Service.CarSimulator(80);
            simulator.SimulateCrash(car);

            foreach (var seat in car.Seats)
            {
                Console.WriteLine($"Ülés foglalt: {seat.IsOccupied}, légzsák nyílt: {seat.AirbagOpened}");
            }
        }
    }
}
