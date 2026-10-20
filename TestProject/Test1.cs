using BPCalculator;
namespace TestProject;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestHighBP()
    {
        var pressure = new BloodPressure()
        {
            Systolic = 70,
            Diastolic = 190,
        };

        BPCategory expected = BPCategory.High;
        BPCategory actual = pressure.Category;
        
        Assert.AreEqual(expected, actual);
    }
}