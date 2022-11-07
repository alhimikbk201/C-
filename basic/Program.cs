int n, m;

string number1, number2;

Console.Write("Введите число наименьшее число диапозона ");

number1 = Console.ReadLine()!;

int.TryParse(number1, out m);


Console.Write("Введите наибольшее число диапозона ");

number2 = Console.ReadLine()!;

int.TryParse(number2, out n);

PrintNaturalNumber(m, n);


void PrintNaturalNumber(int _lesserNumber, int _moreNumber) {

    if(_moreNumber >= _lesserNumber ) {
        Console.Write($"{_lesserNumber} ");
        PrintNaturalNumber(_lesserNumber + 1, _moreNumber);
    } 

}

