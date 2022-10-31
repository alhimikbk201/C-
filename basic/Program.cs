int amountNumb;
int count = 0;
string number1;
Console.Write("Введите количество чисел ");

number1 = Console.ReadLine()!;

int.TryParse(number1, out amountNumb);
int [] numbers = new int[amountNumb];
for(int i = 1; i <= amountNumb; i++) {
    int a;
    Console.Write($"Введите число {i} ");
    int.TryParse(Console.ReadLine()!, out a);
    numbers[i -1] = a;
}

for(int i = 0; i < numbers.Length; i++) {
    if(numbers[i] > 0)
    count++;
}

Console.Write($"Количество положительных чисел {count}");
