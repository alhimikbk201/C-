int n,m;

string number1, number2;

Console.Write("Введите число строк");

number1 = Console.ReadLine()!;

int.TryParse(number1, out m);


Console.Write("Введите число столбцов");

number2 = Console.ReadLine()!;

int.TryParse(number1, out n);

double[,] array = new double [m, n];

for(int i = 0; i < m; i++) {
    for(int j = 0; j < n; j++) {

        array[i, j] = Math.Round(new Random().NextDouble()*20 - 10, 1);
        Console.Write($"{array[i, j]} ");

    }

    Console.WriteLine();
} 

