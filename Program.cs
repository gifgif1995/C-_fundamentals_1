using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Next Problem");

            //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++ )
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Next Problem");

            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++ )
            {
                if(i % 3 ==0)
                    Console.WriteLine(i + "Fizz");
                if(i % 5 == 0)
                    Console.WriteLine(i + "Buzz");
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + "FizzBuzz");
            } 
            

            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            Console.WriteLine("Next Problem While Loops");

            int a = 1;
            while (a <= 255)
            {
                Console.WriteLine(a);
                a = a + 1;
            }

            Console.WriteLine("Next Problem While Loops");

            int b = 1;
            while (b <= 100)
            {
                if (b % 3 == 0 && b % 5 == 0)
                Console.WriteLine(b);
                b = b + 1;
            }
        }
    }
}
