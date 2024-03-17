using System;

namespace Lesson1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Сalculate(args);
            Console.WriteLine($"Результат вычислений: {result}");
        }

        static double Сalculate(string[] expression)
        {
            double result = 0;
            for (int i = 0; i < expression.Length - 1; i += 2)
            {
                double firstNumber;
                if (i == 0)
                {
                    firstNumber = Convert.ToDouble(expression[i]);
                }
                else
                {
                    firstNumber = result;
                }
                double secondNumber = Convert.ToDouble(expression[i + 2]);
                string simvol = expression[i + 1];
                result = СheckSimvol(firstNumber, secondNumber, simvol);
            }
            return result;
        }
        static double СheckSimvol(double firstNumber, double secondNumber, string simvol)
        {
            double result = 0;
            switch (simvol)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}
