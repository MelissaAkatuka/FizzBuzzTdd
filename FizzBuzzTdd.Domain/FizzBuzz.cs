using System;

namespace FizzBuzzTdd.Domain
{
    public class FizzBuzz
    {
        public string GetValue(int input)
        {
            if (input % 3 == 0)
                return "FIZZ";

            return input.ToString();
        }
    }
}
