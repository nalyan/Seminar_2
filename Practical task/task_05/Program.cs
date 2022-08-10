// Найти кубы чисел от 1 до N
Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int k = 1;
for (k = 1; k<=N; k++)
{
    Console.WriteLine($"{k}^3 = {k*k*k}");
}