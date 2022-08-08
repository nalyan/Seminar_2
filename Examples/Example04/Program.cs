Console.Clear();

int i = 1;
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (i=1; i<=N; i++)
{
    Console.WriteLine($"{i}*{i}={i*i}");
}
