using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsAppl1_4

{
    class Program
    {
        static void Visitka()
        {
            string Line = "******************************";
            string str = "БЭИ 1901";
            Int32 X = 10;
            string name1 = "Блинова";
            string name2 = "Орлов";
            Console.WriteLine(Line);
            Console.WriteLine(" Группа {0} ", str);
            Console.WriteLine(" Бригада {0} ", X);
            Console.WriteLine(" 1) {0}, 2) {1} ", name1, name2);
            Console.WriteLine(Line);
            return;
        }
        static void Lab2(Double a, Double x)
        {
            Double y;
            y = (1 - Math.Exp(-a * x)) / (x + Math.Exp(-x));
            Console.WriteLine("Результат при a = {0} и x = {1} y = {2:0.000}", a, x, y);
            return;
        }
        static void Lab3(int[] X, int n)
        {
            int S = 0, c = 0;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                X[i] = rand.Next(-20, 20);
                Console.Write(" {0:###} ", X[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                if (X[i] < X[0])
                {
                    S = S + X[i];
                    c++;
                }
            Console.WriteLine("Сумма чисел меньше первого S = {0} количество C = {1}", S, c);
            return;
        }
        static void Main(string[] args)
        {
            Double a = 6.17, x = 3.12, y;
            int n = 10;
            int[] X = new int[n];
            Random rand = new Random();
            // Генерация массива X с помощью ДСЧ
            for (int i = 0; i < n; i++)
            {
                X[i] = rand.Next(-20, 20);
            }
            Console.WriteLine();
            Int32 key = 0;
            do
            {
                Console.WriteLine("\n *** МЕНЮ ***");
                Console.WriteLine("1 - Визитка ");
                Console.WriteLine("2 - Вычисление выражений ");
                Console.WriteLine("3 - Сумма положительных элементов массива");
                Console.WriteLine("4 - Выход");
                Console.WriteLine("Введите Нужный номер ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1: Visitka(); break;
                    case 2: Lab2(a, x); break;
                    case 3: Lab3(X, n); break;
                    case 4: break;
                    default: Console.WriteLine("ERROR: Неверный номер!"); break;
                }
            } while (key != 4);
            Console.WriteLine("Программа завершена!");
        }
    }
}