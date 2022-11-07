int n;

string number2;


Console.Write("Введите число ");

number2 = Console.ReadLine()!;

int.TryParse(number2, out n);

PrintNaturalNumber(n);


void PrintNaturalNumber(int _number) {

    if(_number >= 1) {
        Console.Write($"{_number} ");
        PrintNaturalNumber(_number - 1);
    } 

}

