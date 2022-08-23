using System;

namespace LabaCShCons
{
    class Program
    {
        static void Vizitka()
        {
            string Line = "******************************";
            string str = "БЭИ 1901";
            int X = 10;
            string name1 = "Блинова";
            string name2 = "Орлов";
            Console.WriteLine(Line);
            Console.WriteLine(" Группа  {0} ", str);
            Console.WriteLine(" Бригада {0} ", X);
            Console.WriteLine(" 1) {0}, 2) {1} ", name1, name2);
            Console.WriteLine(Line);
            return;
        }
        static void Laba2(Double a, Double x)
        {
            double z;
            z = (1 - Math.Exp(-a * x)) / (x + Math.Exp(-x));
            Console.WriteLine("При a = {0} и x = {1}\n варажение z = (1 - Math.Exp(-a * x)) / (x + Math.Exp(-x)) равно: {2}", a, x, z);
            return;
        }
        static void Laba3(int[]X,int n)
        {
            int S = 0, c = 0;
            Console.WriteLine("Исходный массив:");
            for(int i =0;i<n;i++)
            {
                Console.Write("{0}  ", X[i]);
                if (X[i]<X[0])
                {
                    S += X[i];
                    c++;
                }
            }
            Console.WriteLine("\n Сумма элеметов меньше первого = {0}, их количество = {1}", S, c);
            return;
        }
        static void Main(string[] args)
        {
            double a = 6.17, x = 3.12;
            int n = 10;
            int[] X = new int[n];
            Random rand = new Random();
            for (int i =0;i<n;i++)
            {
                X[i] = rand.Next(-20, 20);
            }
            Console.WriteLine();
            int key = 0;
            do
            {
                Console.WriteLine("\n*** МЕНЮ ***");
                Console.WriteLine("1 - Визитка");
                Console.WriteLine("2 - Вычисление выражений");
                Console.WriteLine("3 - Сумма элементов массива меньше первого");
                Console.WriteLine("4 - Выход");
                Console.WriteLine("Введите число");
                key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                        Vizitka();
                        break;
                    case 2:
                        Laba2(a, x);
                        break;
                    case 3:
                        Laba3(X, n);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("ОШИБКА: Неверный номер!");
                        break;
                }
            } while (key != 4);
            Console.WriteLine("Программа завершена!");
        }
    }
}
