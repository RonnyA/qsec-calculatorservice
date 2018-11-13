using Microsoft.VisualStudio.TestTools.UnitTesting;
using qsec_calculatorservice.Controllers;
using qsec_calculatorservice.Models;

namespace qsec_calculatorservice.tests
{
    [TestClass]
    public class MathControllerTests
    {
        private MathController mathController;
        public MathControllerTests()
        {
            mathController = new MathController();
        }
        //4,2 should generate the response 2.
        [TestMethod]
        public void Test_Substracting_Ints_Returns_Correct_Answer()
        {
            var item = new CalcItem() { x = 4, y = 2 };
            var result = mathController.Substract(item);
            Assert.AreEqual(result, 2);
        }

        // 11.5, 12.5 should generate the response -1
        [TestMethod]
        public void Test_Substracting_Decimal_Returns_Correct_Answer()
        {
            var item = new CalcItem() { x = 11.5, y = 12.5 };
            var result = mathController.Substract(item);
            Assert.AreEqual(result, -1);
        }
    }
}
