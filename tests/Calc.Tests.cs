using calc;
using NUnit.Framework;
using Shouldly;

namespace test
{
    [TestFixture]
    public class Tests {

        public StringCalculator SetUp(){
            return new StringCalculator();
        }

        [Test]
        public void Add_EmptyInput_ReturnsZero() {
            var calc = SetUp();

            var result = calc.Add("");

            result.ShouldBe(0);
        }

        [TestCase("0",0)]
        [TestCase("1",1)]
        public void Add_IntNumberInput_ReturnsSameNumber(string input, int expected) {
            var calc = SetUp();

            var result = calc.Add(input);

            result.ShouldBe(expected);
        }

        [TestCase("1,1",2)]
        [TestCase("2,1",3)]
        [TestCase("40,2",42)]
        public void Add_MultipleNumbers_ReturnsTheirSum(string input, int expected) {
            var calc = SetUp();

            var result = calc.Add(input);

            result.ShouldBe(expected);
        }
    }
}
