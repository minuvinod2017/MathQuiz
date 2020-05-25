using System;

namespace MathQuiz.Services {
    public class ExponentService : BaseValidationService, ICalculationService {
        public double DoMathFunction (double leftValue, double rightValue) {
            return Math.Pow (leftValue, rightValue);
        }
        public bool IsResultValid (double leftValue, double rightValue, double userValue) {
            double calculatedValue = this.DoMathFunction (leftValue, rightValue);
            return ValidateResult (userValue, calculatedValue);

        }
    }
}