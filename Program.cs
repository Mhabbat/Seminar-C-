﻿// Необходимо написать программу,которые перевернет одномерный массив.
/*

int[]CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue,maxValue + 1);

      return array;
} 

 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
  
Console.WriteLine();
    }
}


void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++,j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

    }
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
    
int [] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);  */

// Необходимо написать программу которые на вход принимает три числа и проверяет,может ли существовать триугольник со сторонами такой длины.
// Подсказка
// Сумма двух строна всегда больше третей стороны.

/*
bool Treeangle(int a,int b,int c)
{
    if (a+b > c && b+c > a && c+a > b)
    return true;
    else
    return false;
}
Console.WriteLine("Сторона 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сторона 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сторона 3: ");
int c = Convert.ToInt32(Console.ReadLine());
bool result = Treeangle(a,b,c);
Console.WriteLine(result);   */

// Необходимо не используй рекурсию вывести первое n чисел Fibonacci первое два число Fibonacci это a и b.

/*int [] RandomArray(int a,int b,int size)
{
    int[] array = new int [size];
    array[0] = a;
    array[1] = b;
    for(int i =2; i < size; i++)
        array[i] = array[i-2] + array[i-1];
        return array;
}
 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
  
          
}         
Console.WriteLine("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Размер ряда Fibonacci: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] result = RandomArray(a,b,size);
ShowArray(result);
*/

// Необходимо написать программу,которые будет создавать копию из одного массива с поьощью по элементного копирование.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) {
  int[] array = new int[size];

  for (int i = 0; i < size; i++) {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void ShowArray(int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int[] CopyArray (int[] array, int size)
{
  int[] newArray = new int[size];
  for (int i = 0; i < array.Length; i++)
    newArray[i] = array[i];
  return newArray;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ShowArray(CopyArray(newArray, length)); */