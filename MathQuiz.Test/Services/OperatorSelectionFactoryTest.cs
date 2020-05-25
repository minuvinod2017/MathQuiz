using System;
using MathQuiz.Services;
using Xunit;

namespace MathQuiz.Test.Services {
    public class OperatorSelectionFactoryTest {
        public OperatorSelectionFactoryTest () {
            _sut = new OperatorSelctionFactory ();
        }

        public OperatorSelctionFactory _sut { get; set; }

        [Theory]
        [InlineData ("+", typeof (AdditionService))]
        [InlineData ("addition", typeof (AdditionService))]
        [InlineData ("-", typeof (SubtractionService))]
        [InlineData ("subtraction", typeof (SubtractionService))]
        [InlineData ("*", typeof (MultiplicationService))]
        [InlineData ("multiplication", typeof (MultiplicationService))]
        [InlineData ("/", typeof (DivisionService))]
        [InlineData ("division", typeof (DivisionService))]
        [InlineData ("^", typeof (ExponentService))]
        [InlineData ("exponant", typeof (ExponentService))]
        public void Should_Get_Right_Operator (string stringOperator, Type expectedObject) {

            var x = _sut.SelectTheCalculationOperator (stringOperator);
            Assert.IsType (expectedObject, x);

        }

    }
}