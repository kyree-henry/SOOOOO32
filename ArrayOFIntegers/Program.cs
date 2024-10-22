namespace ArrayOFIntegers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 3,5,5,5 };
            IConsole console = new ConsoleWrapper();
            List<string> output = console.Run(arr);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }

    public interface IConsole
    {
        List<string> Run(int[] arr);
    }

    public class ConsoleWrapper : IConsole
    {
        public List<string> Run(int[] arr)
        {
            List<string>? results = new ();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
                {
                    results.Add("FizzBuzz");
                } 
                else if (arr[i] % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else if (arr[i] % 3 == 0)
                {
                    results.Add("Fizz");
                }
            }

            return results;
        }
    }
}