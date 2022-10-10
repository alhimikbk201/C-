int a, b, c;

string number1, number2, number3;
Console.Write("Введите первое число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

Console.Write("Введите второе число");

number2 = Console.ReadLine()!;

int.TryParse(number2, out b);

Console.Write("Введите третье число");

number3 = Console.ReadLine()!;

int.TryParse(number3, out c);



if(a > b ) {
    if(a > c)  {
        Console.Write($"max {a}");
    } else {
        Console.Write($"max {c}");
    }
} else {
    if(b > c) {
        Console.Write($"max {b}");
    } else {
        Console.Write($"max {c}");
    }
}