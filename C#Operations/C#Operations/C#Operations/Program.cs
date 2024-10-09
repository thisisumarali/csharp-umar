namespace Operators
{
    class ArithmeticOperator {
        public static void Main()
        {
            double secondNumber = 4.2, result;
            int firstNumber = 12;
            int num1 = 12, num2 = 2, rem;

            // Addition Operator

            result = firstNumber + secondNumber;
            Console.WriteLine("The firstNumber is {0} and the SecondNumber is {1} and the Addition of both numbers is: {2}", firstNumber, secondNumber, result);

            // Subtraction Operator
            result = firstNumber - secondNumber;
            Console.WriteLine("Subtraction of two numbers: " + result);

            // Multiplication Operator
            result = firstNumber * secondNumber;
            Console.WriteLine("Multiplication of two numbers: " + result);

            // Division Operator
            result = firstNumber - secondNumber;
            Console.WriteLine("Divisions of two numbers: " + result);

            // Modulas Operator
            rem = num1 % num2;
            Console.WriteLine("Modulas of two numbers: " + rem);


            // # RELATION OPERATOR
            bool res;
            int Number1 = 5, Number2 = 10;

            res = (Number1 == Number2);
            Console.WriteLine(res);

        }
    }

}
