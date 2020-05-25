namespace MathQuiz.Services {
    public abstract class BaseValidationService {
        public virtual bool ValidateResult (double inputValue, double outputValue)
        {
            return inputValue == outputValue;
        }
    }
}