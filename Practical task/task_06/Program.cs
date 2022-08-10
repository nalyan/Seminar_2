// Найти сумму чисел от 1 до А
Console.Clear();

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int count = 1;
int sum = 0;
for (count=1; count<=A; count++)
{
    sum = sum + count;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");