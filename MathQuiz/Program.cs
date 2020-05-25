using System;
using System.Diagnostics;
using MathQuiz.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MathQuiz {
    class Program {

        private static IServiceProvider _serviceProvider;

        private static double _firstNumber = 0;
        private static double _secondNumber = 0;
        
        private static double _userResult = 0;
        private static string _operation;
        private const string CORRECT = "correct";
        
        private const string WRONG = "wrong";

        static void Main (string[] args) {

            RegisterServices ();
            AskQuestions ();

            var service = new OperatorSelctionFactory();
            var calService = service.SelectTheCalculationOperator(_operation);
            var result = calService.DoMathFunction (_firstNumber, _secondNumber);

            string resultToReturn = calService.IsResultValid(_firstNumber, _secondNumber, _userResult) == true ? CORRECT : WRONG;

            Console.WriteLine ($"\nYour calculation for {_firstNumber} {_operation} {_secondNumber} was {resultToReturn}. Result = {result}");
            Console.ReadKey ();

            DisposeServices ();

        }

        private static void RegisterServices () {
            var services = new ServiceCollection ();

            services.AddScoped<OperatorSelctionFactory> ();

            _serviceProvider = services.BuildServiceProvider (true);
        }

        private static void DisposeServices () {
            if (_serviceProvider == null) {
                return;
            }
            if (_serviceProvider is IDisposable) {
                ((IDisposable) _serviceProvider).Dispose ();
            }
        }

        private static void AskQuestions () {

            //Ask user first number
            Console.WriteLine ("Type you first number :");
            string stringFirstNumber = Console.ReadLine ();
            _firstNumber = Convert.ToDouble (stringFirstNumber);

            //Ask user second number
            Console.WriteLine ("Type you second number :");
            string stringSecondNumber = Console.ReadLine ();
            _secondNumber = Convert.ToDouble (stringSecondNumber);

            //Ask user operation to use
            Console.WriteLine ("Enter the operation + (addition), - (soustraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");
            _operation = Console.ReadLine ();

             //Ask user for the ans
            Console.WriteLine ("Enter your value :");
            _userResult = Convert.ToDouble (Console.ReadLine ());
        }
    }
}