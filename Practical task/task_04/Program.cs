// Найти расстояние между точками в пространстве 2D/3D
int k = 0;
while (k == 0)
{
    Console.Clear();
    Console.WriteLine("Введите '2' для расчета расстояния между точками в 2D и '3' - для расчета в 3D:");
    int number = int.Parse(Console.ReadLine());
    if (number == 2) k = 2;
    else if (number == 3) k = 3;
}
if (k == 2)
{
    Console.WriteLine("Введите координаты первой точки A: ");
    Console.Write("x1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки B: ");
    Console.Write("x2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("y2: ");
    int y2 = int.Parse(Console.ReadLine());
    float distance = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
    Console.WriteLine($"Расстояние между двумя точками A и B = {Math.Sqrt(distance)}");
}
else
{
    Console.WriteLine("Введите координаты первой точки A: ");
    Console.Write("x1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("z1: ");
    int z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки B: ");
    Console.Write("x2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("y2: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("z2: ");
    int z2 = int.Parse(Console.ReadLine());
    float distance = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1);
    Console.WriteLine($"Расстояние между двумя точками A и B = {Math.Sqrt(distance)}");
}