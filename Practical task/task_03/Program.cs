// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
string coord = "";
if (number < 1 || number > 4) Console.WriteLine("Нет такой четверти");
else
{
    if (number == 1) coord = "x > 0 ; y > 0";
    else if (number == 2) coord = "x < 0 ; y > 0";
    else if (number == 3) coord = "x < 0 ; y < 0";
    else if (number == 4) coord = "x > 0 ; y < 0";

    Console.WriteLine($"Для {number} четверти соответствуют слудующие диапазоны координат: [{coord}]");
}

