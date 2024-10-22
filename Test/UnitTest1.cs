using ArrayOFIntegers;
using Shouldly;

namespace Test
{
    public class Tests
    {
        [TestCase(new int[] { 1 }, new string[] { })]
        [TestCase(new int[] { 2 }, new string[] { })]
        [TestCase(new int[] { 3 }, new string[] { "Fizz" })]
        [TestCase(new int[] { 5 }, new string[] { "Buzz" })]
        [TestCase(new int[] { 15 }, new string[] { "FizzBuzz" })]
        [TestCase(new int[] { 1, 2, 3, 5, 15 }, new string[] { "Fizz", "Buzz", "FizzBuzz" })]
        public void Run_Test(int[] arr, string[] result)
        {
            IConsole consoleWrapper = new ConsoleWrapper();

            List<string> output = consoleWrapper.Run(arr);

            output.ShouldBe(result);
        }
    }
}