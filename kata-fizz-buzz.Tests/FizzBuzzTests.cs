namespace kata_fizz_buzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_Throw_Exception_When_Input_Is_Less_Than_1()
        {
            var process = new FizzBuzz();
            Assert.Throws<ArgumentOutOfRangeException>(() => process.Do(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => process.Do(-1));
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "FizzFizz")]
        [InlineData(5, "BuzzBuzz")]
        [InlineData(15, "FizzBuzzBuzz")]
        public void Should_Return_Correct_String(int input, string output)
        {
            var process = new FizzBuzz();
            var response = process.Do(input);
            Assert.Equal(output, response);
        }
    }
}
