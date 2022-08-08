Console.Clear();

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine());

int count = 0;
int result = 1;

while (count < B)
{
    result = result*A;
    count++;
}
Console.WriteLine(result);


// 
// int NumberStep(int numberDigit, int numberStep)
// {
//     int index = 1;
//     int result = numberDigit;
// 
//     while(index < numberStep)
//     {
//         result = result * numberDigit;
//         index++;
//     }
//     return result;
// }
// 
// Console.Write("Введите число A: ");
// int numberA = int.Parse(Console.ReadLine());
// 
// Console.Write("Введите число B: ");
// int numberB = int.Parse(Console.ReadLine());
// 
// int result = NumberStep(numberA, numberB);
// 
// Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равняется {result}");
// 