void ShowTwoNumber(int _a) {

    int _b;

    _b = (_a % 100)/10;

Console.Write($"{_b}");

}

int a;
string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

ShowTwoNumber(a);

