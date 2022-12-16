using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {//عمر محمد عبد القتاح حسن عماره 
            //مجموعه 2
            //سكشن 14
            Console.Write("please enter First Num : ");
            int FirstNum = int.Parse(Console.ReadLine());
            Console.Write("please enter second Num : ");
            int secondNum = int.Parse(Console.ReadLine());


            bool Prime = true;
            Console.WriteLine("Prime Numbers between " + FirstNum + " to " + secondNum + " :");
            for (int a = FirstNum; a <= secondNum; a++) 
            {
                for (int b = 2; b <= 100; b++)
                {
                    if (a != b && a % b == 0) 
                    {
                        Prime = false;

                        break;
                    }
                }
                if (Prime)
                {
                    Console.Write("\t" + a); 
                }
                Prime = true;
            }



            Console.ReadKey(); 
        }
    }
}
