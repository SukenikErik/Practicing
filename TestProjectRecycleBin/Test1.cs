using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectiveWasteSystem.RecycleBin;
using SelectiveWasteSystem.Models;

namespace TestProjectRecycleBin
{
    [TestClass]
    public class SelectiveBinTests
    {
        [TestMethod]
        public void PaperBin_Accepts_Paper()
        {
            var bin = new SelectiveBin("Paper bin", new[] { typeof(Paper) });
            var result = bin.TryAdd(new Paper());
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PaperBin_Rejects_PlasticBottle()
        {
            var bin = new SelectiveBin("Paper bin", new[] { typeof(Paper) });
            var result = bin.TryAdd(new PlasticBottle());
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GlassBin_Accepts_Only_GlassJar()
        {
            var bin = new SelectiveBin("Glass Jar bin", new[] { typeof(GlassJar) });
            Assert.IsTrue(bin.TryAdd(new GlassJar()));
            Assert.IsFalse(bin.TryAdd(new Paper()));
            Assert.IsFalse(bin.TryAdd(new PlasticBottle()));
            Assert.IsFalse(bin.TryAdd(new OrganicWaste()));
        }
    }
}
