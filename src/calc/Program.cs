using System;

namespace calc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            StringCalculator calc = new StringCalculator();
            Console.WriteLine(calc.Add("2,3"));
        }
    }
}
