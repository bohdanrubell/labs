using System;

namespace program;

class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter the first num: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second num: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the sign: ");
            string sign = Console.ReadLine();

            MathProxy test = new MathProxy();
            double res = 0;
            if (sign == "+")
            {
                res = test.add(firstNumber, secondNumber);
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
            }
            else if (sign == "-")
            {
                res = test.sub(firstNumber, secondNumber);
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
            }
        }
    }    
}


