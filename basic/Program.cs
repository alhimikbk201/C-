int n, m, A;

string number1, number2;

Console.Write("Введите число  ");

number1 = Console.ReadLine()!;

int.TryParse(number1, out m);


Console.Write("Введите число ");

number2 = Console.ReadLine()!;

int.TryParse(number2, out n);




A = ack(m, n);

Console.Write($"{A}");

int ack(int _m, int _n) {


    if (_m == 0) {
        return _n + 1;
    }
    else if ((_m > 0) && (_n == 0)) {
        return ack(_m - 1, 1);
    }
    else if ((_m > 0) && (_n > 0)) {
        return ack(_m - 1, ack(_m, _n - 1));
    } else {
        return 0;
    }

    
}

