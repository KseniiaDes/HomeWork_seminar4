// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16


Console.WriteLine("Для возведения числа A в натуральную степень B введите значения: ");
Console.Write("A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// double Power(int a, int b)
// {
//     double power = Math.Pow(a, b);
//     return power;
// }

int Power(int a, int b)
{
    int power = 1;
    for (int i = 0; i < b; i++)
    {
        power = power * a;
    }
    return power;
}

if (numberB > 0)
{
    int result = Power(numberA, numberB);
    Console.WriteLine(result);
}
else Console.WriteLine("Введите натуральное число B");