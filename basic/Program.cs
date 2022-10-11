int a, b;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

b = (a % 100)/10;

Console.Write($"{b}");

