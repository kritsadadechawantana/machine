using System;
using Xunit;
using machine;

namespace machine.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Caculate()
        {
            var cal = new Calculator();
            var result = cal.Calculate(1500, 3000);
            Assert.Equal(1, result.ThousandBath);
            Assert.Equal(1, result.FiveHundredBath);
        }

        [Fact]
        public void Caculate2()
        {
            var cal = new Calculator();
            var result = cal.Calculate(2000, 2450);
            Assert.Equal(4, result.HundredBath);
            Assert.Equal(1, result.FiftyBath);
        }

        [Fact]
        public void Caculate3()
        {
            var cal = new Calculator();
            var result = cal.Calculate(2530, 3000);
            Assert.Equal(4, result.HundredBath);
            Assert.Equal(1, result.FiftyBath);
            Assert.Equal(1, result.TwentyBath);
        }
    }
}
