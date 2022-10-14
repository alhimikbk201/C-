int MainPow(int _a, int _n) {

    int _pow = 1;

    for(int i = 0; i <= _n; i++) {

        _pow *= _a;

    }

    return _pow;
}


int a, n;

string number1, number2;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

Console.Write("Введите степень");

number2 = Console.ReadLine()!;

int.TryParse(number1, out n);

Console.Write(MainPow(a, n));
