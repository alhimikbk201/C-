double k1 = 0, b1 = 0, k2 = 0, b2 = 0;
double x, y;

string number1 = "", number2 = "", number3 = "", number4 = "";

Console.Write("Введите " + nameof(k1));

number1 = Console.ReadLine()!;

double.TryParse(number1, out k1);

Console.Write("Введите " + nameof(b1));

number2 = Console.ReadLine()!;

double.TryParse(number2, out b1);

Console.Write("Введите " + nameof(k2));

number3 = Console.ReadLine()!;

double.TryParse(number3, out k2);

Console.Write("Введите " + nameof(b2));

number4 = Console.ReadLine()!;

double.TryParse(number4, out b2);


x = (b2 - b1)/(k1 - k2);
y = k1*x + b1;

Console.Write($"Точка пересечения ({x}, {y})");



