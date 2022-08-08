Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
{
    Console.WriteLine("Число " +number+ " кратно 7 и 23");
}
else if (number % 7 == 0)
{
    Console.WriteLine("Число " +number+ " кратно 7");
}
else if (number % 23 == 0)
{
    Console.WriteLine("Число " +number+ " кратно 23");
}
else
{
    Console.WriteLine("Число " +number+ " не кратно 7 и 23");
}