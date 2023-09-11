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


Console.WriteLine("\nTask 33");
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