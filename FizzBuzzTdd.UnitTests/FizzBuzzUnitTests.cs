using FizzBuzzTdd.Domain;
using Xunit;

namespace FizzBuzzTdd.UnitTests
{
    public class FizzBuzzUnitTests
    {
        private FizzBuzz sut;
        public FizzBuzzUnitTests()
	    {
            sut = new FizzBuzz();

	    }

        [Fact]
        public void FizzBuzz_When1_Returns1()
        {
            // Arrange            
            var expected = "1";

            // Act
            var actual = sut.GetValue(expected);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_When2_Returns2()
        {
            //Arrange
            var expected = "2";

            // Act
            var actual = sut.GetValue(expected);

            // Assert
            Assert.Equal(expected, actual);

        }

    }
}
