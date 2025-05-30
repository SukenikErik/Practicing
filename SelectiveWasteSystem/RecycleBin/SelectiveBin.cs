using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectiveWasteSystem.Models;

namespace SelectiveWasteSystem.RecycleBin
{
    public class SelectiveBin
    {
        public string Name { get; }
        private readonly List<Type> _acceptedTypes;
        private readonly List<Waste> _contents = new();

        public SelectiveBin(string name, IEnumerable<Type> acceptedWasteTypes)
        {
            Name = name;
            _acceptedTypes = acceptedWasteTypes.ToList();
        }

        public bool TryAdd(Waste waste)
        {
            if (_acceptedTypes.Contains(waste.GetType()))
            {
                _contents.Add(waste);
                Console.WriteLine($"{waste.Name} accepted.");
                return true;
            }

            Console.WriteLine($"{waste.Name} rejected.");
            return false;
        }

        public void ShowContents()
        {
            Console.WriteLine($"\n{Name} contains:");
            foreach (var item in _contents)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }

        public IReadOnlyList<Waste> Contents => _contents.AsReadOnly();
    }
}
