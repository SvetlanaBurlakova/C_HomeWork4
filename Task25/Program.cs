/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

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
int Power(int number1, int number2)
{
    int result =1;
    for (int i=1; i<=number2;i++)
    {
        result*=number1;
    }
    return result;
}
int number1=GetNumber("Введите число А:");
int number2=GetNumber("Введите число В:");
int result=Power(number1,number2);
Console.WriteLine($"{number1} в степени {number2} = {result} ");