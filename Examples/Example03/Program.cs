Console.Clear();

Console.WriteLine ("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int n1 = number % 10;
int n2 = number % 100 / 10;
int n3 = number % 1000 / 100;
int n4 = number % 10000 / 1000;
int n5 = number / 10000;

int result = n1*10000+n2*1000+n3*100+n4*10+n5;

Console.WriteLine(result);

if (number == result) {Console.WriteLine("Числа являются палиндромом");}
else {Console.WriteLine("Числа НЕ являются палиндромом");}

// if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 /10 ) {Console.WriteLine("Числа являются палиндромом");}
// else {Console.WriteLine("Числа НЕ являются палиндромом");}
