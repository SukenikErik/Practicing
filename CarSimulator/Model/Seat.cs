using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator.Model
{
    public class Seat
    {
        public bool IsOccupied { get; set; }
        public bool AirbagOpened { get; private set; }

        public Seat(bool isOccupied)
        {
            IsOccupied = isOccupied;
            AirbagOpened = false;
        }

        public void OpenAirbag()
        {
            AirbagOpened = true;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
