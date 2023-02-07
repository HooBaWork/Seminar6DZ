/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//С консоли от пользователя принимаем 4 точки: b1,k1,b2,k2.Запихиваем их в массив или в переменные .Т к данных немного,думаю лучше сразу в переменные типа double/float.
Console.WriteLine("Введите точку начала прямой 1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку начала прямой 2");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку конца прямой 1");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку конца прямой 2");
double k2 = double.Parse(Console.ReadLine());

void result( double b1, double k1, double b2, double k2)    //Полученные данные отправляем в функцию,для нахождения точки пересечения двух прямых.Точка это координаты x,y.
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) 
{
Console.Write("Прямые не пересекаются");
}
else if((k1 == k2) && (b1 == b2))
{
Console.Write("Прямые совпадают");
}
else
Console.Write($"Точка пересечения прямых: ({x}; {y})");
}

result(b1, k1, b2, k2);
