using FizzBuzzTdd.Domain;
using Xunit;

namespace FizzBuzzTdd.UnitTests
{
    public class FizzBuzzUnitTests
    {
        [Fact]
        public void FizzBuzz_When1_Returns1()
        {
            // Arrange            
            FizzBuzz sut = new FizzBuzz();
            var expected = "1";

            // Act
            var actual = sut.GetValue(expected);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
