﻿//  Задача No1
// Создать массив и заполнить его целыми числами 
// от 1 до N (N – произвольное натуральное число). 
// Вывести элементы массива на экран.
// Пример 1
// N= 4 12 3 4
// Пример 2
// Т =6
// 12 3 4 5 6

// int n = 10;
// int [] arr = new int [n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
//     //Console.Write(arr[i]);
//     //Console.Write(' ');
//     Console.Write($"{arr[i]} ");
//     i = i + 1;
// }

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length) // оператор вычислания длины массива
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}