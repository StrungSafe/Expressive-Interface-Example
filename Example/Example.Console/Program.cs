namespace Example.Console
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var example = new Example();

            Console.WriteLine("The example contains the names:");

            foreach (string exampleName in example.Names)
            {
                Console.WriteLine($"\t{exampleName}");
            }

            example.Names[0] = "Fred";

            Console.WriteLine("Trying to overwrite the first name with Fred");
            Console.WriteLine($"The first name is: {example.Names[0]}");

            var expressiveExample = new ExpressiveExample();

            Console.WriteLine("The expressive example contains the names:");

            foreach (string exampleName in expressiveExample.Names)
            {
                Console.WriteLine($"\t{exampleName}");
            }

            //expressiveExample.Names[0] = "Fred";
            Console.WriteLine("The compiler prevents us from even attempting to overwrite the first name");
        }
    }
}