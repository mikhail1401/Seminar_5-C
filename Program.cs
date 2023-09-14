// Arrays Массивы

Console.WriteLine("\nTask 31");
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12];

int sumPosNum = 0;
int sumNegNum = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + ", ");

    if (array[i]>0)
    {
        sumPosNum+=array[i];
    }
    else if(array[i]<0)
    {
        sumNegNum+=array[i];
    }
}

Console.WriteLine($"\nSum of negative numbers is {sumNegNum}, and sum of positive numbers is {sumPosNum}.");


Console.WriteLine("\nTask 32");
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array2 = new int[12];

for (int i=0; i<array2.Length; i++)
{
    array2[i] = new Random().Next(-9, 10);
    Console.Write(array2[i] + ", ");
}

Console.WriteLine("");

for (int i=0; i<array2.Length; i++)
{
    array2[i] = array2[i] * -1;
    Console.Write(array2[i] + ", ");
}


Console.WriteLine("\n\nTask 33");
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

System.Console.WriteLine("Enter a number: ");
int num = System.Convert.ToInt32(System.Console.ReadLine());

int[] array3 = new int[15];

bool numIsPresent = false;

for (int i=0; i<array3.Length; i++)
{
    array3[i] = new Random().Next(-10, 11);
    Console.Write(array3[i] + ", ");

    if(num==array3[i])
    {
        numIsPresent = true;
    }
}

if (numIsPresent==true) Console.WriteLine($"\nYes, number {num} is present in the array.");
else Console.WriteLine($"\nNo, number {num} is NOT present in the array.");


Console.WriteLine("\nTask 35");
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array4 = new int[123];

int count = 0;

for (int i=0; i<array4.Length; i++)
{
    array4[i] = new Random().Next(0, 160);
    Console.Write(array4[i] + ", ");

    if (array4[i]>=10 && array4[i]<=99)
    {
        count++;
    }
}

Console.WriteLine($"\nThere are {count} numbers in the segment between [10, 99].");


Console.WriteLine("\nTask 37");
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.WriteLine("Enter the size of the 1st array: ");
int num5 = Convert.ToInt32(Console.ReadLine());

int[] array51 = new int[num5];
int[] array52 = new int[array51.Length/2 + array51.Length%2];   // To find out the size of the result array. It depends on if the size of array51 is odd or even.

for (int i=0; i<array51.Length; i++)
{
    array51[i] = new Random().Next(0, 11);
    Console.Write(array51[i] + ", ");
}

Console.WriteLine();

for (int i=0; i<array52.Length; i++)
{
    array52[i] = array51[i] * array51[array51.Length-1-i];
    if (i==array51.Length-1-i)
    {
        array52[i] = array51[i];
    }

    Console.Write(array52[i]+", ");
}

