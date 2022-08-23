// kursach.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <locale.h>
#include <malloc.h>

void Input(int *arr, int n);
void Output(int* arr, int n);
void Add(int* arr, int n, int num);
void Del(int* arr, int n);
void Shift(int* arr, int n, int a, int b);
int SearchChet(int* arr, int n, int a);
int SearchMax(int* arr, int n);
int SearchMin(int* arr, int n);
void Sort(int* arr, int n);
void Copy();

int main()
{
	int n, i, *arr, s;
	printf("Enter n: ");
	scanf("%d", &n);
	arr = (int*)malloc(n * sizeof(int));
	srand(time(NULL));
	printf("\n");
	Input(arr, n);
	Output(arr, n);
	s = rand() % 100;
	Add(arr, n, s);
	n++;
	printf("\n");
	Output(arr, n);
	Sort(arr, n);
	printf("\n");
	Output(arr, n);
	


}

void Input(int* arr, int n)
{
	int i;
	for (i = 0; i < n; i++)
	{
		arr[i] = rand() % 100;
	}
}

void Output(int* arr, int n)
{
	int i;
	for (i = 0; i < n; i++)
	{
		printf("%4d", arr[i]);
	}
}

void Add(int* arr, int n, int num)
{
	n++;
	arr = (int*)realloc(arr, n * sizeof(int));
	arr[n-1] = num;
}

void Del(int* arr, int n)
{
	n--;
	arr = (int*)realloc(arr, n * sizeof(int));
}

void Shift(int* arr, int n, int a, int b)
{
	int c;
	c = arr[a];
	arr[a] = arr[b];
	arr[b] = c;
}

int SearchChet(int* arr, int n, int a)
{
	int i = 0;
	while (arr[i] % 2 != 0)
	{
		i++;
	}
	return i;
}

int SearchMax(int* arr, int n)
{
	int i, max = arr[0], maxNum = 0;
	for (i = 1; i < n; i++)
	{
		if (arr[i] > max)
		{
			maxNum = i;
		}
	}
	return maxNum;
}

int SearchMin(int* arr, int n)
{
	int i, min = arr[0], minNum = 0;
	for (i = 1; i < n; i++)
	{
		if (arr[i] < min)
		{
			minNum = i;
		}
	}
	return minNum;
}

void Sort(int* arr, int n)
{
	int i, j, c;
	for (i = 0; i < n - 1; i++)
	{
		for (j = 0; j < n - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				Shift(arr, n, j, j + 1);
			}
		}
	}

}