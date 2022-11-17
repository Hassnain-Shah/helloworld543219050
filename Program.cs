using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for +,2 for -,3 for *,4 for /,5 for %,6 for square,7 for square root,8 for power ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n== 1)
            {
                int sum = num1 + num2;
                Console.Write("Sum of num1 and num2 is:"+ sum );
            }
            else if (n == 2)
            {
                int sub = num1 - num2;
                Console.Write("Sub of num1 and num2 is:" + sub);
            }
            else if (n == 3)
            {
                int mul = num1 * num2;
                Console.Write("Mul of num1 and num2 is:" + mul );
            }
            else if (n == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {
                    int div = num1 / num2;
                    Console.Write("div of num1 and num2 is:" + div);
                }
            }
            else if (n == 5)
            {
                int mod = num1 % num2;
                Console.Write("Modulus of num1 and num2 is:" + mod);
                /*{
                    if (mod == 0)
                    {
                        Console.WriteLine("even");
                    else
                        {
                            Console.WriteLine("odd");
                        }
                    }
                }*/
                
            }
            else if (n == 6)
            {
                int square1  = num1 * num1;
                int square2  = num2 * num2;
                Console.Write("Square of num1 :" + square1);
                Console.Write("Square of num2 :" + square2);


            }
            else if (n==7)
            {

                Console.WriteLine("The square root of num1 is :" + Math.Sqrt(num1));
                Console.WriteLine("The square root of num2 is :" +Math.Sqrt(num2));


            }
            else if (n == 8)
            {
                Console.WriteLine("The power of num1 as base and num2 as exponential power is :" + Math.Pow(num1,num2));
                //Console.WriteLine("The square root of num2 is :" + Math.Sqrt(num2));

            }


            Console.ReadLine();








        }
            
        }
        
    }

