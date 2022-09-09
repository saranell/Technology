using Technology;
namespace TechnologyTests;

[TestClass]
public class UnitTest1
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
}
