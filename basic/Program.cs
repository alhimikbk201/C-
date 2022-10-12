void CubeNumber(int _a) {
    for(int i = 1; i <= _a; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
    }
    }
int a;
string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;
int.TryParse(number1, out a);
 

CubeNumber(a);
