using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycles
{
    class Program
    {
        static void Main(string[] args)
        // for вывод квадрата чисел
        {
            //  for(int i=0; i<9; i++)//цыкл возрастает пока условие true
            //    {
            //        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //    }
            //    Console.ReadKey();

            //******************************
            // без указания параметров цикла прцесс будет бесконечный
            //    int i = 0;
            //for ( ; ;)
            //    {
            //    Console.WriteLine($"Квадрат числа{++i} равен {i*i}");
            //    }
            //    Console.ReadKey();
            //****************************************
            //int i = 0;
            //for ( ; i<9; )
            //{
            //    Console.WriteLine($"Квадрат числа{++i} равен {i * i}");
            //}
            //Console.ReadKey();

            //*****************************************
            // do

            //int i = 6;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);
            //Console.ReadKey();
            // ***********************
            // int i = -1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);
            //Console.ReadKey();
            //*****************
            //while
            //int i = 7;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //Console.ReadKey();
            //******************************

            //Операторы Continui and break
            //for(int i=0; i<9; i++)
            //{
            //    if (i == 6)
            //        break;
            //    Console.WriteLine(i);

            //}
            //Console.ReadKey();
            //********************
            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 6)
            //        continue;
            //    Console.WriteLine(i);

            //}
            //Console.ReadKey();

            //****************************
            //foreach- перебор массива

            //int[] num = new int[] { 8, 6, 8, 2, 9, 7, 2, 12, 84, 3, 9 };
            //foreach (int i in  num )
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //********************
            //int[] num = new int[] { 5, 554, 2, 6, 8, 9, 8 };
            //for(int i=0; i<num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadKey();
            //*******************************

            //int[] num = new int[] { 1, 5, 7, 6, 8, 9 };
            //for(int i=0; i< num.Length; i++)
            //{
            //    num[i] = num[i] * 2;
            //    Console.WriteLine(num[i]);
            //}
            //Console.ReadKey();
            //***********************************

            //int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            //foreach (int i in num)
            //{
            //    Console.WriteLine($"{i}");


            //}
            //Console.ReadKey();

           // ************************************
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = num.GetUpperBound(0) + 1;
            int columns = num.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{num[i , j]}\t");
                }
                Console.ReadKey();

                //Console.Write("Введите имя: ");
                //string name = Console.ReadLine();

                //Console.Write("Введите возраст: ");
                //int age = Convert.ToInt32(Console.ReadLine());

                //Console.Write("Введите рост: ");
                //double height = Convert.ToDouble(Console.ReadLine());

                //Console.Write("Введите размер зарплаты: ");
                //decimal salary = Convert.ToDecimal(Console.ReadLine());

                //Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");

                //Console.ReadKey();
}

            } 
    }
}
