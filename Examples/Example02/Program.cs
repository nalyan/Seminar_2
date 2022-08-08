Console.Clear();
Console.WriteLine ("Введите координату x, не равную нулю: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите координату y, не равную 0: ");
int y = int.Parse (Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine ("Первая четверть.");
}
else if (x<0 && y>0)
{
    Console.WriteLine ("Вторая четверть.");
}
else if (x<0 && y<0)
{
    Console.WriteLine ("Третья четверть.");
}
else if (x>0 && y<0)
{
    Console.WriteLine ("Четвертая четверть.");
}
