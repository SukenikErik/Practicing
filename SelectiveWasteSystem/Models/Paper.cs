using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectiveWasteSystem.Models
{
    public class Paper : Waste, IRecyclable
    {
        public override string Name => "Paper";
        public bool CanBeRecycled() => true;
    }
}
