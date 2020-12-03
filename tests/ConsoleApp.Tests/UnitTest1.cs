using ClassLibrary;
using Xunit;

namespace ConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Class1.Add(1, 2));
        }
    }
}
