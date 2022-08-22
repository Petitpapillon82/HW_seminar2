//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber == 1)
{
    Console.WriteLine("понедельник");    
}
if (dayNumber == 2)
{
    Console.WriteLine("вторник");    
}
if (dayNumber == 3)
{
    Console.WriteLine("среда");    
}
if (dayNumber == 4)
{
    Console.WriteLine("четверг");    
}
if (dayNumber == 5)
{
    Console.WriteLine("пятница");    
}
if (dayNumber == 6)
{
    Console.WriteLine("суббота");    
}
if (dayNumber == 7)
{
    Console.WriteLine("воскресенье");    
}

  if (dayNumber < 1 || dayNumber > 7)  
  {
    Console.WriteLine("ошибка: это не день недели, введите цифру от 1 до 7");
  }
  else if (dayNumber == 6 || dayNumber == 7) 
  {
     Console.WriteLine("это выходной день");
  }
  else Console.WriteLine("это рабочий день");
