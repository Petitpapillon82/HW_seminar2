//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
if(n <= 99)
{
   Console.WriteLine("Третьей цифры нет"); 
}

else if(n > 99)
{
       Console.WriteLine((n / 100) % 10);
}   