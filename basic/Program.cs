int a;

string number1;
Console.Write("Введите первое число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);






if (a % 2 == 0) {
    Console.Write($"{a} четное");
} else {
    Console.Write($"{a} не четное");
}