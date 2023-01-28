/* Напишите программу,которая принимает на вход кординаты точки( x и y),причем x y выдает номер четверти плоскости,
который находится это точка.
void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and > 0");
    else if(quadrant == 3) Console.WriteLine("x<0 and y<0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine ("Wrong input");
}
Console.Write ("Input a number of quadrant:");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);*/
/* Задача 2 Напишите программу,которая принимает на вход число (N) и выдает квадраты число от 1 до N.
void Quadrant (int n)
{
    int count =1;
    Console.WriteLine("квадраты чисел:");
    while(count < n+1)
    {
        Console.Write(count*count +" ");
        count++;
    }

}
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Quadrant(n);
*/


/* Напишите программу,которая принимает на вход кординаты двух точек и находит расстояние между ними в 2D прострпнстве.
int GetQuadrant( int x, int y)
{
    int quadrant=-1;
   if(x>0 && y>0) quadrant = 1;
   if(x<0 && x>0) quadrant = 2;
   if(x<0 && y<0) quadrant = 3;
   if(x>0 && y<0) quadrant = 4;
return quadrant;
}
Console.WriteLine("Введите кординаты точек: x & y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if(GetQuadrant(x,y) == -1) Console.WriteLine("Некорректный ввод");
else Console.WriteLine("Номер четверти"+ GetQuadrant(x,y));
*/

