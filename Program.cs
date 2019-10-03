using System;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random1 = new MultiplicativeCongruentMethod();
            var random2 = new LinearCongruentMethod();

            var testing1 = new Testing(random1);
            var testing2 = new Testing(random2);

            Console.WriteLine($"Хи-квадрат для мультипликативного конгруэнтного метода = {testing1.ChiSquared()}");
            Console.WriteLine($"Хи-квадрат для линейного конгруэнтного метода = {testing2.ChiSquared()}");
        }
    }
}
