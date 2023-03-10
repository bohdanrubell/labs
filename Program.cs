using System;
using System.Security.Cryptography;

namespace program;

public class CheckingOperand : Exception
{
    public CheckingOperand()
    {
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Do you want to run the program? Write (YES) to confirm or (NO) to stop");
            string choise = Console.ReadLine();
            if (choise.ToUpper() == "YES")
            {
                Console.WriteLine("List of operation:");
                Console.WriteLine("'+' - Addition");
                Console.WriteLine("'-' - Substract");
                Console.WriteLine("'*' - Multiply");
                Console.WriteLine("'/' - Division");
                Console.WriteLine("'^' - Finding the root");
                Console.Write("Select the operation: ");
                
                string sign = Console.ReadLine();
                MathProxy proxy = MathProxy.GetMath();
                double res = 0;
                if (sign == "+")
                {
                    
                    Console.Write("Enter the first num: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second num: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    res = proxy.add(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "-")
                {
                    Console.Write("Enter the first num: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second num: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    res = proxy.sub(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "*")
                {
                    Console.Write("Enter the first num: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second num: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    res = proxy.mul(firstNumber, secondNumber);
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                }
                else if (sign == "/")
                {
                    Console.Write("Enter the first num: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second num: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        if (secondNumber == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            res = proxy.div(firstNumber, secondNumber);
                            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign, secondNumber, res);
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Divide by zero! Try again!");
                    }
                    
                    
                }
                else if (sign == "^")
                {

                    Console.Write("Enter the number : ");
                    double number = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        if (number < 1 || number > 10000)
                        {
                            throw new CheckingOperand();
                        }
                        else
                        {
                            Console.WriteLine(proxy.root(number));
                        }
                    }
                    catch (CheckingOperand ex)
                    {
                        Console.WriteLine("Wrong range! Try again!");
                    }

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