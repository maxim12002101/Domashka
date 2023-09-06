// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


/*
Console.Write("Введите количество элементов массива:" );
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int kol(int[] Array)
{
int i=0;
int sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}

mas(m);
Console.Write($"\n Чисел больше нуля: {kol(Array)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/