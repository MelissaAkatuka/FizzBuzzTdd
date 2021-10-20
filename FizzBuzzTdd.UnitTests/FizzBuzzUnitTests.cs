using System;
using Xunit;

namespace FizzBuzzTdd.UnitTests
{
    public class FizzBuzzUnitTests
    {
        [Fact]
        public void Buzzer_When1_Returns1() // [MethodUnderTest]_[Scenario]_[ExpectedResult]
        {
            FizzBuzz sut = new FizzBuzz();
        }
    }
}
