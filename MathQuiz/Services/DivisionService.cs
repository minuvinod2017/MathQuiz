namespace MathQuiz.Services {
    public class DivisionService : BaseValidationService, ICalculationService {
        public double DoMathFunction (double leftValue, double rightValue) {
            return leftValue / rightValue;
        }
        public bool IsResultValid (double leftValue, double rightValue, double userValue) {
            double calculatedValue = this.DoMathFunction (leftValue, rightValue);
            return ValidateResult (userValue, calculatedValue);

        }

    }
}