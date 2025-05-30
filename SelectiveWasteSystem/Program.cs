using SelectiveWasteSystem.Models;
using SelectiveWasteSystem.RecycleBin;
using System;
using System.Collections.Generic;

namespace SelectiveWasteSystem
{
    class Program
    {
        static void Main()
        {
            var paperBin = new SelectiveBin("Paper bin", new[] { typeof(Paper) });
            var plasticBottleBin = new SelectiveBin("Plastic bottle bin", new[] { typeof(PlasticBottle) });

            List<Waste> wastes = new()
            {
                new Paper(),
                new PlasticBottle(),
                new GlassJar(),
                new OrganicWaste()
            };

            Console.WriteLine("Trying to add waste to the paper bin:");
            foreach (var waste in wastes)
            {
                paperBin.TryAdd(waste);
            }

            Console.WriteLine("\nTrying to add waste to the plastic bottle bin:");
            foreach (var waste in wastes)
            {
                plasticBottleBin.TryAdd(waste);
            }

            paperBin.ShowContents();
            plasticBottleBin.ShowContents();
        }
    }
}