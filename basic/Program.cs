int a, b;

string number1, number2;
Console.Write("Введите первое число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

Console.Write("Введите первое число");

number2 = Console.ReadLine()!;

int.TryParse(number2, out b);

if(a > b) {
    Console.Write($"max {a}");
} else {
    Console.Write($"max {b}");
}