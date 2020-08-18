using calc;
using NUnit.Framework;
using Shouldly;

namespace tests {
    public class Tests {
        private Calc CreateTestCalc() {
            return new Calc();
        }

        [Test]
        public void GetTotal_RightAfterCreation_Returns0() {
            var testCalc = CreateTestCalc();

            var result = testCalc.GetTotal();

            result.ShouldBe(0);
        }

        [TestCase(2, 2)]
        [TestCase(-2, -2)]
        public void GetTotal_AddOnce_ReturnsAddedNumberItself(int num, int expectedValue) {
            var testCalc = CreateTestCalc();

            testCalc.Add(num);
            var result = testCalc.GetTotal();

            result.ShouldBe(expectedValue);
        }

        [TestCase(2, 3, 5)]
        [TestCase(-2, -3, -5)]
        [TestCase(-2, 2, 0)]
        public void GetTotal_AddSequentially_ReturnsSum(int num1, int num2, int expectedValue) {
            var testCalc = CreateTestCalc();

            testCalc.Add(num1);
            testCalc.Add(num2);
            var result = testCalc.GetTotal();

            result.ShouldBe(expectedValue);
        }

        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        public void GetTotal_ResetAfterAdd_ReturnsZero(int num, int expectedValue) {
            var testCalc = CreateTestCalc();

            testCalc.Add(num);
            testCalc.Reset();
            var result = testCalc.GetTotal();

            result.ShouldBe(expectedValue);
        }
    }
}
