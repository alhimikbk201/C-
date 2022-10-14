int sum = 0;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

 char [] symbol = number1.ToCharArray();

 for(int i = 0; i < symbol.Length; i++) {
    
    sum += (int)Char.GetNumericValue(symbol[i]);
    
 }

Console.Write(sum);


