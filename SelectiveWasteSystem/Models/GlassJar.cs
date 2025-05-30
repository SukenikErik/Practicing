using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectiveWasteSystem.Models
{
    public class GlassJar : Waste, IRecyclable
    {
        public override string Name => "GlassJar";
        public bool CanBeRecycled() => true;
    }
}
