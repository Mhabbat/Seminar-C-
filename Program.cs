  // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
  /*
  int[]CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue,maxValue + 1);

      return array;
} 

 
 
 /* int [] CreateArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
       Console.Write($"Input an {i + 1} element: ");
       array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
      

      return array;  
} */
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
  
Console.WriteLine();
    }
}

int GetSumOfNegative(int[] array)
{
  int sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] < 0)
         sum += array[i];
    
  }
    return sum;
}


Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
    
int [] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.WriteLine("Sum of negative elements is " + result); */ 

// Напишите программу замена элементов массива.Положительные элементы заменить на отицательный и наоборот. 
/*
  int[]CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue,maxValue + 1);

      return array;
}
int[] GetReverse(int[] array)
{
 for(int i = 0; i < array.Length; i++)
    array[i]=array[i]*-1;
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




Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
    
int [] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

int[] result = GetReverse(newArray);
ShowArray(result);

Console.WriteLine("Sum of negative elements is ");
*/
// Задайте массив.Напишите программу которая определяет,присутствует ли заданное число в массиве.
 /* 
  int[]CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue,maxValue + 1);

      return array;
}
bool GetSearch(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    { 
      if (array[i] == x) return true;
    }
    return false;

    
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
  
Console.WriteLine();
    }
}




Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
    
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number:  ");

// Задайте одномерный массив из m случайных чисел.Найдите количество элементов массива,значения которых лежит отрезке a,b.
/*
 int[]CreateRandomArray(int size,int minValue,int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue,maxValue + 1);

      return array;
} 

int GetCountFind(int[] array,int MinNum,int MaxNum)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
      if (array[i] >= MinNum && array[i] <= MaxNum) count++;
  return count;
  
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
  
Console.WriteLine();
    }
}
Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minNumber value of elements: ");
int MinNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxNumber value of elements: ");
int MaxNum = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

int result = GetCountFind(newArray,MinNum,MaxNum);
Console.WriteLine("Количество элементов: " + result);

*/


