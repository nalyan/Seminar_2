// Определить количество цифр в числе
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;
while (Math.Abs(number) >= 1)
{
    number = number / 10;
    count++;
    Console.WriteLine($"{number} {count}");
}
Console.WriteLine($"количество цифр в числе {number} = {count}");