// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2) Console.WriteLine("Первое число является квардратом воторого");
else if (number2 == number1*number1) Console.WriteLine("Второе число является квадратом первого");
else Console.WriteLine("Каждое из чисел не является квадратом другого");