using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectiveWasteSystem.Models
{
    public class OrganicWaste : Waste, IRecyclable
    {
        public override string Name => "OrganicWaste";
        public bool CanBeRecycled() => true;
    }
}
