// Laba1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <stdio.h>
#include <math.h>
#include <clocale>

using namespace std;

void main()
{
	setlocale(LC_CTYPE, "rus");
	float z, y, a, x;
	printf("\n Введите исходные данные:");
	scanf_s("%f %f", &a, &x);
	z = (1 - exp(-a * x)) / (1 + exp(-a * x));
	y = z + log(a + x);
	printf("\n Результаты:");
	printf("\n y = %f, z = %f", y, z);
}

