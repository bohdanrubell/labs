using System;
using System.Security.Cryptography;

namespace program;

class MainClass
{
        
    public static void Main(string[] args)
    {
        

        while (true)
        {
            Console.WriteLine("Would you like start the program? Write (YES) to confirm or (NO) to stop");
            string choise = Console.ReadLine();
            if (choise.ToUpper() == "YES")
            {
                Console.Write("Enter the first num: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second num: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the sign: ");
                string sign = Console.ReadLine();

                MathProxy proxy = new MathProxy();
                double res = 0;
                if (sign == "+")
                {
                    res = proxy.add(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "-")
                {
                    res = proxy.sub(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "*")
                {
                    res = proxy.mul(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "/")
                {
                    res = proxy.div(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "^")
                {
                    
                    double firstResult = proxy.root(firstNumber);
                    double secondResult = proxy.root(secondNumber);
                    Console.WriteLine("Root of first num: {0}",firstResult);
                    Console.WriteLine("Root of second num: {0}",secondResult);
                }
                
            }
            else if (choise.ToUpper() == "NO")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
           
        }
    }    
}


