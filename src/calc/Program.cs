using System;

namespace calc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calculating on the fly! Amazingly Accurate Answer to Life, the Universe and Everything:");
            Calc calc = new Calc();
            Console.WriteLine(calc.GetTotal());
            calc.Add(314);
            Console.WriteLine(calc.GetTotal());
            calc.Add(20);
            Console.WriteLine(calc.GetTotal());
            calc.Add(-420);
            Console.WriteLine(calc.GetTotal());
            calc.Add(128);
            Console.Write("...And finally, the answer is: ");
            Console.WriteLine(calc.GetTotal());
        }
    }
}
