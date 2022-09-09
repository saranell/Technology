using Technology;
namespace TechnologyTests;

[TestClass]
public class UnitTest1
{
    [TestMethod] //Computer test 1 of 3
    public void TestIncreaseRam()
    {
        Computer testComputer = new Computer(2, 3, "Windows");
        Assert.AreEqual(2, testComputer.Ram);
        testComputer.IncreaseRam(3);
        Assert.AreEqual(5, testComputer.Ram);
    }

    [TestMethod] //Computer test 2 of 3
    public void TestIncreaseStorage()
    {
        Computer testComputer = new Computer(2, 3, "Windows");
        Assert.AreEqual(3, testComputer.Storage);
        testComputer.IncreaseStorage(10);
        Assert.AreEqual(13, testComputer.Storage);
    }


    [TestMethod] //Smartphone test 1 of 3
    public void TestDownloadApp()
    {
        SmartPhone testSmartphone = new SmartPhone(2, 3, "Apple", 2020, "5x3", "AT&T", List < App > application);

    }
}
