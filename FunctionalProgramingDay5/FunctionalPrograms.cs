using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuctionalProgramingDay5
{
    public static class FunctionalPrograms
    {
        public static void FlipCoin()
        {
            Console.WriteLine("Enter number you want flip coin");
            int flips = Convert.ToInt32(Console.ReadLine());
            float headPercentage = 0, tailPercentage = 0;
            int head = 0, tail = 0;

            for (int i = 0; i < flips; i++)
            {
                Random random = new Random();
                int coin = random.Next(2);
                if (coin == 0)
                {
                    head++;
                    Console.WriteLine("head increment " + head);
                }
                else if (coin == 1)
                {
                    tail++;
                    Console.WriteLine("tail increment " + tail);
                }
            }
            headPercentage = (head * 100) / flips;
            Console.WriteLine("Head percentage is " + headPercentage);
            tailPercentage = (tail * 100) / flips;
            Console.WriteLine("tail percentage is " + tailPercentage);
        }

        public static void HarmonicSeries()
        {
            Console.WriteLine("Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine(sum);
        }

        public static void LeapYear()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("is a leap year");
            }
            else
            {
                Console.WriteLine("is not a leap year");
            }
        }
        public static void PowerOfTwo()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 2 || num > 32)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int val = 1;
                for (int i = 0; i < num; i++)
                {
                    val = val * 2;
                }
                Console.WriteLine(val);
            }
        }
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
            if(num == 2)
            {
                Console.WriteLine(num);
            }
        }
        public static void SwapingTwoNumber()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before Swaping "+num1+" "+num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After Swaping " + num1+" "+num2);
        }

        public static void Remainder()
        {
            int dividend, remainder, divisor=0, quotient;
            Console.WriteLine("Enter dividend");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter remainder");
            remainder = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("quotient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
        public static void EvenOdd()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("is a even number ");
            }
            else
            {
                Console.WriteLine("is a odd number ");
            }
        }
        public static void VowelAndConstant()
        {
            Console.WriteLine("Enter String");
            char ch = char.Parse(Console.ReadLine());
            if(ch== 'a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch+" Is a vowel");
            }
            else
            {
                Console.WriteLine(ch+" Is a Constant");
            }
        }
        public static void ThreeLargestNumber()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>=num2 && num1 >= num3)
            {
                Console.WriteLine(num1+" first number is large");
            }
            else if (num2>=num1 && num2>=num3)
            {
                Console.WriteLine(num2+" second number is large");
            }
            else if (num3>=num1 && num3>=num2)
            {
                Console.WriteLine(num3+" third number is large");
            }
        }
    }
}
