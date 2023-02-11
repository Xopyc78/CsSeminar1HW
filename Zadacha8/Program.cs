// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = N/2;
int start = 2;
int i =0;
while (i<count)
{
  Console.WriteLine(start);  
  start=start + 2;
  i++;
}