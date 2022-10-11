void ThreeNumber(string _str) {
    char [] _number;
    _number = _str.ToCharArray();

    
        if(_str.Length > 3) {
           Console.Write(_number[2]);
        } else {
             Console.Write("Нет третьей цифры");
            
        }

    
}

string number1;
Console.Write("Введите первое число");

number1 = Console.ReadLine()!;

ThreeNumber(number1);
