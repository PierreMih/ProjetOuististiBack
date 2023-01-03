using ProjetOuististiDomain.Calculs;

namespace ProjetOuististiBackTests.Calcul
{
    [TestClass]
    public class CalculTests
    {
        private readonly float _1 = 3;
        private readonly float _2 = 4;

        [TestMethod]
        public void ResultIsInitializedOrFound()
        {
            CalculAddition calc = new(_1, _2);
            Assert.IsNotNull(calc.GetResult());
        }

        [TestMethod] public void ResultHasAValue() {
            CalculAddition calc = new(_1, _2);
            Assert.IsNotNull(calc.GetResult().Value);
        }

        [TestMethod]
        public void Addition()
        {
            CalculAddition calc = new(_1, _2);
            Assert.AreEqual(3.0 + 4.0, calc.GetResult());
        }

        [TestMethod]
        public void Soustraction()
        {
            CalculSoustraction calc = new(_1, _2);
            Assert.AreEqual(3.0 - 4.0, calc.GetResult());
        }

        [TestMethod]
        public void Multiplication()
        {
            CalculMultiplication calc = new(_1, _2);
            Assert.AreEqual(3.0 * 4.0, calc.GetResult());
        }

        [TestMethod]
        public void Division()
        {
            CalculDivision calc = new(_1, _2);
            Assert.AreEqual(3.0 / 4.0, calc.GetResult());
        }
        
        [TestMethod]
        public void DivisionParZero()
        {
            CalculDivision calc = new(_1, 0);
            Assert.ThrowsException<DivideByZeroException>(() => calc.GetResult());
        }

        
    }
}
