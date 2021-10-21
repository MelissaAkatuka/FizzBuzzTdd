namespace FizzBuzzTdd.Domain
{
    public class FizzBuzz
    {
        public string GetValue(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FIZZBUZZ";

            if (input % 3 == 0)
                return "FIZZ";

            if (input % 5 == 0)
                return "BUZZ";

            return input.ToString();
        }
    }
}
