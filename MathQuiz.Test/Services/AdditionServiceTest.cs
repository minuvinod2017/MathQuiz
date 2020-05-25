using MathQuiz.Services;
using Xunit;

namespace MathQuiz.Test.Services {
    public class AdditionServiceTest {
        public AdditionServiceTest()
        {
            _sut = new AdditionService();
        }

        public AdditionService _sut { get; set; }

        [Theory]
        [InlineData (3,4)]
        [InlineData (0,80)]
        [InlineData (6.4,9.9)]
        public void DoMathFunctionTest (double leftValue, double rightValue) {

           var val = _sut.DoMathFunction(leftValue,rightValue);
           Assert.True(val == (leftValue+rightValue));
        }
    }
}