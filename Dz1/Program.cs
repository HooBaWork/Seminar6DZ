/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите размер массива");//Записываем числа пользователя в массив через функцию returnArray() .Пользователь сам указывает размер массива через консоль.
int size = int.Parse(Console.ReadLine());
int[] resultArray = returnArray();
int[] returnArray()
{

   int[] array = new int[size];
   for(int i = 0;i < size;i++)
   {
    
    Console.WriteLine("Введите число");
    array[i] = int.Parse(Console.ReadLine());
   }
   return array;
}


int result(int[] arr) //Отправляем получившийся массив в функцию и прогоняем через цикл,в поисках элементов массива,которые больше 0.
{
   int count = 0;
   for(int i = 0;i < size;i++)
    if(resultArray[i] > 0)
    {
        count++;
    }
    return count;
} 

void main()//С оформлением main,да и вообще с форматированием кода ещё разбираться и разбираться ...
{
int res = result(resultArray);
Console.WriteLine($"Количество элементов массива больше 0 -  {res}");
}
main();
