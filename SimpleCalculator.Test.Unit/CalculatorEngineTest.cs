using Microsoft.VisualStudio.TestTools.UnitTesting;
using simple_calculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("add", num1, num2);

            Assert.AreEqual(3, result);
        }

        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("+", num1, num2);

            Assert.AreEqual(3, result);
        }

        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("multiply", num1, num2);

            Assert.AreEqual(2, result);
        }

        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("*", num1, num2);

            Assert.AreEqual(2, result);
        }


    }
}
