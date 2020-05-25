using System;

namespace MathQuiz.Services {

    public class OperatorSelctionFactory {

        public ICalculationService SelectTheCalculationOperator (string stringOperation) {
            if (string.IsNullOrEmpty (stringOperation)) {
                throw new ApplicationException (string.Format ("Operator '{0}' is currently not supported", stringOperation));
            }

            // Convert string choice to integral
            if (stringOperation == "+" || stringOperation == "addition") {
                return new AdditionService ();

            } else if (stringOperation == "-" || stringOperation == "subtraction") {
                return new SubtractionService ();
            } else if (stringOperation == "*" || stringOperation == "multiplication") {
                return new MultiplicationService ();
            } else if (stringOperation == "/" || stringOperation == "division") {
                return new DivisionService ();
            } else if (stringOperation == "^" || stringOperation == "exponant") {
                return new ExponentService ();
            } else {
                //default throw an exception
                throw new ApplicationException (string.Format ("Operator '{0}' is currently not supported", stringOperation));
            }

        }
    }
}