using calc;
using NUnit.Framework;
using Shouldly;

namespace test {
    [TestFixture]
    public class Tests {

        [Test]
        public void AddReturnsZeroForEmpty() {
            StringCalculator calc = new StringCalculator();

            var zero = calc.Add("");
            zero.ShouldBe(0);
        }
    }
}
