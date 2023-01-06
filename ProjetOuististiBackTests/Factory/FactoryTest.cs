using ProjetOuististiDomain.Calculs;
using ProjetOuististiDomain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiBackTests.Factory
{
    [TestClass]
    public class FactoryTest
    {
        private readonly float _1 = 41;
        private readonly float _2 = 3;

        [TestMethod]
        public void IsOperationTypeNumExceptionThrownWhenWrongOpreationTypeIsPassed()
        {
            Assert.ThrowsException<OperationTypeEnumException>(() => CalculFactory.BuildFromValuesAndOpType(_1, _2, "NotAnOperation"));
        }

        [TestMethod]
        public void IsAdditionCorrectlyImplementatedThroughFactory()
        {
            Assert.IsTrue(CalculFactory.BuildFromValuesAndOpType(_1, _2, "Addition").GetType() == typeof(CalculAddition));
        }

        [TestMethod]
        public void IsSubstractionCorrectlyImplementatedThroughFactory()
        {
            Assert.IsTrue(CalculFactory.BuildFromValuesAndOpType(_1, _2, "Soustraction").GetType() == typeof(CalculSoustraction));
        }

        [TestMethod]
        public void IsMultiplicationCorrectlyImplementatedThroughFactory()
        {
            Assert.IsTrue(CalculFactory.BuildFromValuesAndOpType(_1, _2, "Multiplication").GetType() == typeof(CalculMultiplication));
        }

        [TestMethod]
        public void IsDivisionCorrectlyImplementatedThroughFactory()
        {
            Assert.IsTrue(CalculFactory.BuildFromValuesAndOpType(_1, _2, "Division").GetType() == typeof(CalculDivision));
        }
    }
}
