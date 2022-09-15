using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {
        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            Laptop testLaptop = new Laptop(2, 3, "Apple", 2020, "10x12");
            Assert.IsNotNull(testLaptop.Id);
            Assert.AreEqual(2, testLaptop.Ram);
            Assert.AreEqual(3, testLaptop.Storage);
            Assert.AreEqual("Apple", testLaptop.OperatingSystem);
            Assert.AreEqual(2020, testLaptop.SoftwareDate);
            Assert.AreEqual("10x12", testLaptop.Dimensions);
        }

        [TestMethod]   
        public void TestNeedsSoftwareUpdate()
        {
            Laptop testLaptop = new Laptop(2, 3, "Apple", 2020, "10x12");
            Assert.IsTrue(testLaptop.NeedsSoftwareUpdate());

            testLaptop.SoftwareDate = 2022;
            Assert.IsFalse(testLaptop.NeedsSoftwareUpdate());

        }
    }
}
