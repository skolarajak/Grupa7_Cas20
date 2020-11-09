using System;

namespace G7Cas20
{
    class Program
    {
        static void Main(string[] args)
        {

            // Null coalescing
            
            int? x = null;
            int? z = 100;
            int? rezab;

            rezab = x ?? z;
            Console.WriteLine("Vrednost rezab = {0}", rezab);

            if (x < 10)
            {
                Console.WriteLine("Uradi nesto");
            } else
            {
                Console.WriteLine("Uradi nesto drugo");
            }

            // Nullables

            int? num1 = null;
            int num2;
            double rezultat;

            num1 = 4;
            num2 = 3;

            rezultat = Convert.ToDouble(num1 + num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 - num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 * num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 % num2);
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rezultat);

            num1 = 1;
            num2 = 1;
            Console.WriteLine("a. num1 = {0}", num1++);
            Console.WriteLine("a. num2 = {0}", num2--);
            Console.WriteLine("b. num1 = {0}", num1);
            Console.WriteLine("b. num2 = {0}", num2);
            num1 = 1;
            num2 = 1;
            Console.WriteLine("c. num1 = {0}", ++num1);
            Console.WriteLine("c. num2 = {0}", --num2);
            /*
             * i++ =>
             * print i;
             * i = i + 1;
             * 
             * ++i =>
             * i = i + 1;
             * print i
             * 
             */

            Console.WriteLine("======== Mathematical operators");

            num1 = 4;
            num2 = 3;
            bool rez;

            rez = num1 == num2;
            Console.WriteLine("{0} = {1} => {2}", num1, num2, rez);
            rez = num1 != num2;
            Console.WriteLine("{0} != {1} => {2}", num1, num2, rez);
            rez = num1 > num2;
            Console.WriteLine("{0} > {1} => {2}", num1, num2, rez);
            rez = num1 < num2;
            Console.WriteLine("{0} < {1} => {2}", num1, num2, rez);
            rez = num1 >= num2;
            Console.WriteLine("{0} >= {1} => {2}", num1, num2, rez);
            rez = num1 <= num2;
            Console.WriteLine("{0} <= {1} => {2}", num1, num2, rez);

            
            Console.WriteLine("======== Logical operators");
            bool val1, val2;

            val1 = true;
            val2 = false;

            rez = val1 && val2;
            Console.WriteLine("{0} AND {1} => {2}", val1, val2, rez);
            rez = val1 || val2;
            Console.WriteLine("{0} OR {1} => {2}", val1, val2, rez);
            rez = !(val1 || val2);
            Console.WriteLine("{0} OR {1} NOT => {2}", val1, val2, rez);

            int a = 101;
            int b = 201;

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("Value of a = {0} and b = {1}", a, b);
                }
            }
            else
            {
                if (b < 100)
                {
                    Console.WriteLine("a is not 100, and b is {0}", b);
                }
                else
                {
                    Console.WriteLine("b is not less than 100");
                }
            }
            Console.WriteLine("Exact value of a is {0}", a);
            Console.WriteLine("Exact value of b is {0}", b);

            int s;

            s = 4;

            switch(s)
            {
                case 1:
                    Console.WriteLine("s = 1");
                    break;

                case 2:
                    Console.WriteLine("s = 2");
                    break;

                default:
                    Console.WriteLine("DEFAULT: s = {0}", s);
                    break;
            }

            Console.ReadKey();


            // Constants
            /*
            const double PI = 3.14159;
            double r;

            Console.Write("Unesi radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double area = PI * r * r;
            Console.WriteLine("Radijus: {0}, povrsina: {1}", r, area);
            Console.ReadKey();
            */



            
        }
    }
}
