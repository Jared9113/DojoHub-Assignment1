using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
        }

        static void SimpleCalculator()
        {
            
            Console.WriteLine("Enter mathematical expression or 'q' to quit\n " +
                "and press Enter: ");
            string input = Console.ReadLine();

          
                while (input != "q")
                {
                    try
                    {
                        int SignIndex = 0;
                        double num1 = 0, num2 = 0, answer = 0;

                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input[i] == '+' || input[i] == '-' ||
                                input[i] == '*' || input[i] == '/')
                            {
                                SignIndex = i;
                                num1 = double.Parse(input.Substring(0, SignIndex));
                                num2 = double.Parse(input.Substring(SignIndex + 1));
                            }
                        }

                        char Sign = input[SignIndex];

                        switch (Sign)
                        {
                            case '+':
                                answer = num1 + num2;
                                break;
                            case '-':
                                answer = num1 - num2;
                                break;
                            case '*':
                                answer = num1 * num2;
                                break;
                            default:
                                answer = num1 / num2;
                                break;
                        }

                        Console.WriteLine($"{input} = {answer}");
                        

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    Console.WriteLine("\nEnter mathematical expression or 'q' to quit\n " +
                        "and press Enter: ");
                    input = Console.ReadLine();

                }
            
        }

            

            
            
        
    }
}
