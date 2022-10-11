void DayOfTheWeek(int _a) {
    if(_a == 6 || _a == 7) {
        Console.Write("Выходной");
} else {
    if(_a > 7) {
        Console.Write("Не допустимое значение, число должно быть от 1 до 7");
    } else {
        Console.Write("Будний день");
    }
}

}

int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

DayOfTheWeek(a);


   