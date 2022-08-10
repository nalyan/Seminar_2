// Подсчитать сумму цифр в числе
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int figure = 0;
int result = 0;
int k = 10;
int count = Math.Abs(number);

while (count >= 1)
{
    figure = number % k / (k / 10);
    result = result + figure;
    k = k * 10;
    count = count / 10;
}
Console.WriteLine(Math.Abs(result));