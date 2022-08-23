using System;

namespace Laba5CShCons
{
    // Обьявление класса для работы с массивом 
    class Data
    {
        internal static int[] massiv { get; set; }
        internal static int n { get; set; }
    }

    class Program
    {
        // Обьявление функций, которые вызываются из главной функции  
        static void Visitka()
        {
            string Line = "******************************";
            string str = "БЭИ 1901";
            Int32 X = 1;
            string name1 = "Блинова";
            string name2 = "Орлов";
            Console.WriteLine(Line);
            Console.WriteLine(" Группа  {0} ", str);
            Console.WriteLine(" Бригада {0} ", X);
            Console.WriteLine(" 1) {0}, 2) {1} ", name1, name2);
            Console.WriteLine(Line);
            return;
        }
       
        static void Max_out_massiv(int[] X, int n)
        {
            int max;
            int[] Y = new int[n];
            Console.WriteLine("\n Исходный массив:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0:###} ", X[i]);
            }
            max = X[0];
            for (int i = 0; i < n; i++)
            {
                if (X[i] > max)
                    max = X[i];
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (X[i] != max)
                {
                    Y[j] = X[i];
                    j++;
                }
            }
            Console.WriteLine("\n Максимальный элемент = {0:###} ", max);
            Console.WriteLine("\n Mассив без максимального элемента:\n");
            for (int i = 0; i < j; i++)
            {
                Console.Write(" {0:###} ", Y[i]);
            }
        }
        static void Add_end_massiv(int[] X, int n)
        {
            Console.WriteLine("\n Исходный массив:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0:###} ", X[i]);
            }
            Console.WriteLine("\n Сколько добавить? ");
            Int32 k = Convert.ToInt32(Console.ReadLine());
            Data.n = k;
            Data.massiv = new int[Data.n];
            Random rand = new Random();
            Console.WriteLine("\n  Дополнительный массив, сгенерированный с помощью ДСЧ  : ");
            for (int i = 0; i < Data.n; i++)
            {
                Data.massiv[i] = rand.Next(-20, 20);
                Console.Write(" {0:###}", Data.massiv[i]);
            }
            Console.WriteLine();
            Data.n = n + k;
            int[] Y = new int[Data.n];
            Console.WriteLine("\n Суммарный массив : ");
            for (int i = 0; i < Data.n; i++)
            {
                if (i < n)
                    Y[i] = X[i];
                else
                    Y[i] = Data.massiv[i - n];
                Console.Write(" {0:###} ", Y[i]);
            }
            Console.WriteLine();
            return;
        }
        // *************************************
        static void Main(string[] args)
        {
            Data.n = 10;
            Data.massiv = new int[Data.n];
            Random rand = new Random();
            // Генерация массива с помощью ДСЧ  :  
            for (int i = 0; i < Data.n; i++)
            {
                Data.massiv[i] = rand.Next(-20, 20);
            }
            Int32 key = 0;
            do
            {
                Console.WriteLine("\n***   МЕНЮ   ***");
                Console.WriteLine("1 - Визитка ");
                Console.WriteLine("2 - Найти максимальный элемент и удалить его из массива");
                Console.WriteLine("3 - Добавить в конец исходного массива");
                Console.WriteLine("4 - Выход");
                Console.WriteLine("Введите Нужный номер ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1: 
                        Visitka(); 
                        break;
                    case 2: 
                        Max_out_massiv(Data.massiv, Data.n); 
                        break;
                    case 3: 
                        Add_end_massiv(Data.massiv, Data.n); 
                        break;
                    case 4: 
                        break;
                    default: 
                        Console.WriteLine("ERROR: Неверный номер!"); 
                        break;
                }
            } while (key != 4);
            Console.WriteLine("Программа завершена!");
        }
    }
} 

