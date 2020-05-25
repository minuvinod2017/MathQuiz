namespace MathQuiz.Services {
    public interface ICalculationService {
        double DoMathFunction (double leftValue, double rightValue);
        bool IsResultValid(double leftValue, double rightValue, double userValue);
    }
}