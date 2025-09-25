using ClassLibrary2;

namespace Tests2;

public class UnitTest2
{
    [Fact]
    public void MultiplyTest()
    {
        Assert.Equal(6, Class2.Multiply(2, 3));
    }
}
