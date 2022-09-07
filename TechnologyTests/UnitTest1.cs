namespace TechnologyTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestIncreaseRam()
    {
        Computer testComputer = new Computer(2, 3, true);
        Assert.AreEqual(2, testComputer.Ram);
        testComputer.IncreaseRam(3);
        Assert.AreEqual(5, testComputer.Ram);
    }
}
