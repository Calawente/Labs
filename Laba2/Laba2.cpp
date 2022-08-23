// Laba2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <stdio.h>
#include <math.h>
#include <clocale>

using namespace std;

void main()
{
	setlocale(LC_CTYPE, "rus");
	float z, y, x;
	printf("\n Введите исходные данные:");
	scanf_s("%f", &x);
	if (x < 0)
	{
		y = tan(x + 5);
		z = cos(x - 5);
	}
	else
	{
		y = x * x - 1;
		z = sin(x - 5);
	}
	printf("\n Результаты:");
	printf("\n y = %f, z = %f", y, z);
}

