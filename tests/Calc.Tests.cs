using calc;
using NUnit.Framework;
using Shouldly;

namespace test {
    [TestFixture]
    public class Tests {

        [Test]
        public void Add_EmptyInput_ReturnsZero() {
            var calc = new StringCalculator();

            var zero = calc.Add("");

            zero.ShouldBe(0);
        }

        [TestCase("0",0)]
        [TestCase("1",1)]
        [TestCase("42",42)]
        public void Add_IntNumberInput_ReturnsSameNumber(string input, int expected) {
            var calc = new StringCalculator();

            var result = calc.Add(input);

            result.ShouldBe(expected);
        }

        [Test]
        public void Add_Always_ReturnsInt() {
            var calc = new StringCalculator();

            var result = calc.Add("ABC32");

            result.ShouldBe(0);
        }
    }
}
