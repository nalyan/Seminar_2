// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();

Console.WriteLine("Введите номер дня недели (1-7): ");
int day = int.Parse(Console.ReadLine());

int[] work = { 1, 2, 3, 4, 5 };
int length = work.Length;
int index = 0;
int k = 0;

while (index < length)
{
    if (day == work[index]) 
    {
        Console.WriteLine("Это будний день");
        k = 1;
    }
    index++;
}
if (day == 6 || day == 7) Console.WriteLine("Этот день недели - выходной");
else if (k != 1) Console.WriteLine("Нет такого номера дня недели");