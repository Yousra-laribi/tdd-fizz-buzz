namespace kata_fizz_buzz
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        public string Do(int input)
        {
            if (input < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "Input must be a positive integer.");
            }
            var response = string.Empty;
            if (input % 3 == 0)
            {
                response = FIZZ;
            }
            if (input % 5 == 0)
            {
                response = $"{response}{BUZZ}";
            }
            return string.IsNullOrEmpty(response) ? input.ToString() : response;
        }

    }
}
