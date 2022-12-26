// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int CutNumber(номер ввода)
{
 int sot = число / 100;
 int ed = число % 10;
 int результат = sot * 10 + ed;
 возвращает результат;
}
int randNumber = new Random().Next(100, 1000);
Консоль.Строка записи ("Текущее случайное трехзначное число равно " + randNumber);
int newNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is " + newNumber);
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int number)
{
  int des = number / 10;
  int ed = number % 10;
  int max = 0;
  if (des > ed)
  {
    max = des;
  }
  else
  {
    max = ed;
  }
  return max;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine("Текущее число " + randNumber);
int newNumber = MaxNumber(randNumber);
Console.WriteLine("Максимальное число из текущего " + newNumber);
*/
// Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.

/*
bool InfoNumber(int num1, int num2)
{
  if (num2 % num1 == 0) return true;
  else return false;
} 
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(InfoNumber(num1, num2));
*/
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*Четырехзначный  номер bool(int  num1, int  num2)
{
  если (num1 == num2 * num2 || num2 == num1 * num1) возвращает  true;
  ложный  возврат  еще;
}

Консоль.Write("Введите первое число: ");
Преобразовать = num1  int.ToInt32(консоль.Строка чтения());
Консоль.Write("Введите второе число: ");
Преобразовать = num2  int.ToInt32(консоль.Строка чтения());


если (четырехзначное число(num1, num2))
{
  Консоль.WriteLine("Одно из чисел является квадратом другого");
}
ещё
{
  Консоль.WriteLine("Ни одно число не является квадратом друг друга");
} */