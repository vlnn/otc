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
    }
}
