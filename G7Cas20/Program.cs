using System;

namespace G7Cas20
{
    class Program
    {
        static void Main(string[] args)
        {
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
