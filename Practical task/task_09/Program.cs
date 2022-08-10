// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int k = 1;
long factorial = 1;
for (k=1; k<=N; k++)
{
    factorial = factorial * k;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {factorial}");