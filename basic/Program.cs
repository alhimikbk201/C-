int n;

string number1;
Console.Write("Введите первое число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out n);

int i = 1;

while(i <= n) {
    if (i % 2 == 0) {
    Console.Write($"{i} ");
} 

i++;
} 






