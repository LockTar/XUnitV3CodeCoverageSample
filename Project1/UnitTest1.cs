namespace Project1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test2()
    {
        File.WriteAllText($"C:\\Users\\ralph\\source\\repos\\Tests\\XUnitV3CodeCoverageSample\\Project1\\{Guid.NewGuid()}.txt", DateTime.Now.ToString());
    }
}
