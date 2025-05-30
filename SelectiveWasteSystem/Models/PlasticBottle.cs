using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectiveWasteSystem.Models
{
    public class PlasticBottle : Waste, IRecyclable
    {
        public override string Name => "PlaticBottle";
        public bool CanBeRecycled() => true;
    }
}
