using calc;
using NUnit.Framework;
using Shouldly;

namespace test {
    [TestFixture]
    public class Tests {
        private StringCalculator MakeCalculator() {
            return new StringCalculator();
        }

        [Test]
        public void Add_EmptyInput_ReturnsZero() {
            var calc = MakeCalculator();

            var zero = calc.Add("");

            zero.ShouldBe(0);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("42", 42)]
        public void Add_SingleNumber_ReturnsTheNumber(string input, int expected) {
            var calc = MakeCalculator();

            var result = calc.Add(input);

            result.ShouldBe(expected);
        }

        [TestCase("1,2",3)]
        [TestCase("2,2",4)] // 3 nums?
        [TestCase("40,2",42)]
        public void Add_MultipleNumbers_ReturnsTheirSum(string input, int expected) {
            var calc = MakeCalculator();

            var result = calc.Add(input);

            result.ShouldBe(expected);
        }
    }
}
