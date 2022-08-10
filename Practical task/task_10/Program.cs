// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

int N = new Random().Next(2,100);

// Вариант 1
int count = 2;
for (count=2; count<=N; count+=2)
{
    Console.WriteLine($"{count}^3= {count*count*count}");
}

/*
// Вариант 2
float count = 1;
for (count=1; count<=N; count+=1)
{
    if ((count<10 && count%2==0) || (count>9 && count%10%2==0)) Console.WriteLine($"{count}^3= {count*count*count}");
}
*/