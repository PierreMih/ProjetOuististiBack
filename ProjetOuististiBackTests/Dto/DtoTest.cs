using ProjetOuististiApplication.Objects;
using ProjetOuististiDomain.Calculs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiBackTests.Dto
{
    [TestClass]
    public class DtoTest
    {
        private readonly float _1 = 6;
        private readonly float _2 = 9;

        [TestMethod]
        public void IsCalculInputDtoExplicitConversionThroughFactoryToCalculAbstractCorrect()
        {
            CalculInputDto cid = new CalculInputDto
            {
                input1 = _1,
                input2 = _2,
                OperationType = "Addition",
            };
            CalculAbstract ca = CalculFactory.BuildFromValuesAndOpType(cid.input1, cid.input2, cid.OperationType);
            Assert.IsTrue((ca.Input1 == _1) && (ca.Input2 == _2));
        }

        [TestMethod]
        public void IsCalculAbstractImplementaitonToCalculOutputDtoConversionCorrect()
        {
            CalculDivision cd = new(_1,_2);
            CalculOutputDto cod = new(cd);
            /*Assert.IsTrue((cod.input1 == _1) && (cod.input2 == _2) && (cod.OperationType == "Division") && (cod.output == cd.GetResult()));*/
            Assert.IsTrue(cod.input1 == _1);
            Assert.IsTrue(cod.input2 == _2);
            Assert.IsTrue(cod.OperationType == "Division");
            Assert.AreEqual(cod.output,cd.GetResult());
        }
    }
}
