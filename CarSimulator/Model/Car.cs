using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Model
{
    public class Car
    {
        public int Speed { get; set; }
        public HashSet<Seat> Seats { get; private set; }

        public Car(int speed, IEnumerable<Seat> seats)
        {
            Speed = speed;
            Seats = new HashSet<Seat>(seats);
        }
    }
}
