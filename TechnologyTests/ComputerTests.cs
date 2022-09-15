using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;
namespace TechnologyTests;

[TestClass]
public class ComputerTests
{
    [TestMethod]
    public void TestIncreaseRam()
    {
        Computer testComputer = new Computer(2, 3, "Windows");
        Assert.AreEqual(2, testComputer.Ram);
        testComputer.IncreaseRam(3);
        Assert.AreEqual(5, testComputer.Ram);
    }

    [TestMethod]
    public void TestIncreaseStorage()
    {
        Computer testComputer = new Computer(2, 3, "Windows");
        Assert.AreEqual(3, testComputer.Storage);
        testComputer.IncreaseStorage(10);
        Assert.AreEqual(13, testComputer.Storage);
    }

    [TestMethod]
    public void TestInheritsId()
    {
        Computer testComputer = new Computer(2, 3, "Windows");
        Assert.AreEqual(1, testComputer.Id);
    }
    [TestMethod] //Smartphone test 1 of 3
    public void TestDownloadApp()
    {
        SmartPhone testSmartphone = new SmartPhone(2, 3, "Apple", 2020, "5x3", "AT&T", List < App > application);

    }
}
