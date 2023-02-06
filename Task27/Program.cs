/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

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
int SumDigits(int number)
{
 int sum = 0;

 while (number/10>0)
 {
    sum+=number%10;
    Console.WriteLine(sum);
    number/=10;
    Console.WriteLine(number);
 }
 sum+=number%10;
 return sum;
}

int number=GetNumber("Введите число");

int result = SumDigits(number);

Console.WriteLine($"Сумма цифр числа {number} равянется {result}");