//Напишите программу, которая на вход принимает 3 трехзначных числа и находит среднее арифметическое, 
//далее проверяет больше ли последняя цифра среднего арифметического, чем первая цифра минимума вводимых чисел.
//111, 222, 333 - да
//532, 164, 114 - нет
//551, 235, 631 - цифры равны


Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());

int Avg = (a + b + c) / 3;

Console.WriteLine($"Среднее арифметическое введенных чисел равно {Avg}");

int min = a;
if (b < a) min = b;
if (c < b) min = c;
 Console.WriteLine($"минимум вводимых чисел равен {min}");

//if (Avg>99)
//{
//Console.WriteLine("Последняя цифра среднего арифметического "+Avg.ToString()+" равна "+Avg.ToString()[2]);
//}
//if (min>99)
//{
//Console.WriteLine("Первая цифра минимума "+min.ToString()+" равна "+min.ToString()[0]);
//}

if (Avg.ToString()[2] > min.ToString()[0])
{
    Console.WriteLine("Последняя цифра среднего арифметического больше, чем первая цифра минимума вводимых чисел");
}

else if (Avg.ToString()[2] < min.ToString()[0])
{
    Console.WriteLine("Последняя цифра среднего арифметического меньше, чем первая цифра минимума вводимых чисел");
}
else
{
    Console.WriteLine("Последняя цифра среднего арифметического равна первой цифре минимума вводимых чисел");
}