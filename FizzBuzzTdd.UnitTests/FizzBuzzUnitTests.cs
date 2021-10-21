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

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        public void FizzBuzz_WhenDefault_ReturnsInput(int input)
        {
            //Arrange
            var expected = input.ToString();

            //Act
            var actual = sut.GetValue(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void FizzBuzz_WhenDiv3_ReturnFizz(int input)
        {
            //Arrange
            var expected = "FIZZ";

            //Act
            var actual = sut.GetValue(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]        
        public void FizzBuzz_WhenDiv5_ReturnBuzz(int input)
        {
            //Arrange            
            var expected = "BUZZ";

            //Act
            var actual = sut.GetValue(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        public void FizzBuzz_WhenDiv3and5_ReturnFizzBuzz(int input)
        {
            //Arrange            
            var expected = "FIZZBUZZ";

            //Act
            var actual = sut.GetValue(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
