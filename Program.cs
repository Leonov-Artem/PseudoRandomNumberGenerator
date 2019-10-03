using System;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new LinearCongruentMethod();
            var random = new LinearCongruentMethod();
            var testing = new Testing(random);
            Console.WriteLine(testing.ChiSquared());
        }
    }
}
