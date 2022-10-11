int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

Console.Write(a % 10);
