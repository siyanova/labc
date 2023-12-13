using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            task11();
        }
        static void task1()
        {

            int a = 10;
            while (a >= 1)
            {
                Console.WriteLine(a);
                a--;
            }
        }
        static void task2()
        {
            string line = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                Console.WriteLine(line);
                number--;
            }
        }
        static void task3()
        {
            int a = 10;
            int b = 20;
            int row = 1;
            while (row <= a)
            {
                int column = 1;
                while (column <= b)
                {
                    Console.Write("R");
                    column++;
                }
                Console.WriteLine();
                row++;
            }
        }
        static void task4()
        {

            int a = 1;
            while (a <= 10)
            {
                int b = 1;
                while (b <= 10)
                {
                    int result = a * b;
                    Console.Write(result + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
        static void task5()
        {
            for (int i = 100; i > 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void task6()
        {
            Console.WriteLine("введите m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("введите n");
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(9);
                }
                Console.WriteLine() ;
            }
        }
        static void task7()
        {
            for (int i = 10; i >= 1; i--) { 
                for(int j=1; j <= i; j++)
                {
                    Console.Write(9);
                   
                    
                }
                Console.WriteLine();
            }
        }
        static void task8()
        {
            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(name+" любит меня");
            }
        }
        static void task9()
        {
            for(int i=0; i < 100; i++)
            {
                Console.WriteLine("Я  буду работать за копейки");
            }
        }
        static void task10()
        {
            int result = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number == -1)
                {
                    result += -1;
                    break;
                }
                else result += number;
            }
            Console.WriteLine(result);
        }
        static void task11()
        {

            void initializeArray()
            {
                int[] array = new int[20];
                
                for(int i=1; i < 20; i++)
                {
                   array[i] = int.Parse(Console.ReadLine());
                        
                }
                
            }
        }
    }
}
