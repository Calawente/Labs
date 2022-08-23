using System;
using System.Linq;

namespace KursachCSh
{
    class Program
    {
        static void WriteArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}; ", arr[i]);
            }
        }
        static int[] DelEl(int[]arr, int k)
        {
            for (int i = k; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        static int[] AddEl(int[] arr, int n)
        {
            //Array.Resize(ref arr, arr.Length + n);
            Random rand = new Random();
            for (int i = arr.Length - n; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-20, 20);
            }
            return arr;
        }
        static int[] MaxToMin(int[] arr)
        {
            int max = arr[0], min = arr[0], maxI = 0, minI = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxI = i;
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    minI = i;
                    min = arr[i];
                }
            }
            arr[maxI] = min;
            arr[minI] = max;
            return arr;
        }
        static void Chet(int[] arr)
        {
            int c = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    c = i;
                    break;
                }
            }
            if (c != -1)
            {
                Console.WriteLine("Первый четный элемент: {0} с индексом: {1}", arr[c], c);
            }
            else
            {
                Console.WriteLine("Четных элементов нет");
            }
        }
        static int[] BubbleSort(int[] arr)
        {
            int k;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for(int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        k = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = k;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int n, k = 0;          
            do
            {
                k = 0;
                Console.WriteLine("\nВведите количество элементов в массиве: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n >= 0)
                {
                    k = 1;
                }
                else
                {
                    Console.WriteLine("Неверное число!");
                }
            } while (k == 0);           
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-20, 20);
            }
            int key = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("***МЕНЮ***");
                Console.WriteLine("1 - Вывести массив");
                Console.WriteLine("2 - Удалить элемент");
                Console.WriteLine("3 - Добавить элементы");
                Console.WriteLine("4 - Поменять максимальный и минимальный");
                Console.WriteLine("5 - Первый четный элемент");
                Console.WriteLine("6 - Сортировка");
                Console.WriteLine("10 - Выход");
                Console.Write("Введите число: ");              
                key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (key)
                {
                    case 1:
                        WriteArr(arr);
                        break;
                    case 2:
                        Console.Write("Введите индекс элемента: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (k < n && k >= 0)
                        {
                            n--;
                            Array.Copy(DelEl(arr, 3), arr, n);
                            Array.Resize(ref arr, n);
                        }
                        else
                        {
                            Console.WriteLine("Неверное число!");
                        }
                        break;
                    case 3:
                        Console.Write("Введите количество новых элементов: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        n += k;
                        Array.Resize(ref arr, n);
                        Array.Copy(AddEl(arr, k), arr, n);
                        break;
                    case 4:
                        Array.Copy(MaxToMin(arr), arr, n);
                        break;
                    case 5:
                        Chet(arr);
                        break;
                    case 6:
                        Array.Copy(BubbleSort(arr), arr, n);
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Неверное число!");
                        break;
                }
            } while (key != 10);
        }
    }
}
