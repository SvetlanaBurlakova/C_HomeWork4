/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
!!! Предположу, что нужно найти массив максимум из 8 элементов!!!
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}
Random rnd =new Random();
int arraySize=rnd.Next(1,9);
int [] array = new int[arraySize];
int number =0;
for (int i =0; i<arraySize; i++)
{
    array[i]=GetNumber($"Введите число {i+1}:");
}

Console.Write($"[{string.Join(", ", array)}]");
