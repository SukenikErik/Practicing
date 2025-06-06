using CarSimulator.Model;


namespace CarSimulator.Service
{
    public class CarSimulator
    {
        private readonly int _minimumSpeedToCrash;

        public CarSimulator(int minimumSpeedToCrash)
        {
            _minimumSpeedToCrash = minimumSpeedToCrash;
        }

        public Car SimulateCrash(Car car)
        {
            if (car.Speed >= _minimumSpeedToCrash)
            {
                foreach (var seat in car.Seats)
                {
                    if (seat.IsOccupied)
                    {
                        seat.OpenAirbag();
                    }
                }
            }

            return car;
        }
    }
}