using Microsoft.VisualStudio.TestPlatform.TestHost;
using TestCalculator;


namespace TestCalculator.Test
{
    public class UnitTest1
    {     

        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(5, Program.Addition(1, 4));
        {

        }
    }
}