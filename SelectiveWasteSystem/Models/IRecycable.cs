using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectiveWasteSystem.Models
{
    public interface IRecyclable
    {
        bool CanBeRecycled();
    }
}
