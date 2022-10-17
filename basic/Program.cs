int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

double [] arr = {};

arr = getArr(a);

printArr(arr);

double min = getMinMeaningFromArr(arr);

Console.Write($"Min {min}\n");

double max = getMaxMeaningFromArr(arr);

Console.Write($"Max {max}\n");

double resolt = max - min;

Console.Write($"Разница между максимальным и минимальным значением массива равна {resolt}");


double getMaxMeaningFromArr(double[] _arr) {
   double meaning = _arr[0];

   for(int i = 1; i < _arr.Length; i++) {
    if(meaning < _arr[i]) {

        meaning = _arr[i];
        }

    }

   return meaning;
}






double getMinMeaningFromArr(double[] _arr) {
   double meaning = _arr[0];

   for(int i = 1; i < _arr.Length; i++) {
    if(meaning > _arr[i]) {

        meaning = _arr[i];
        }

    }

   return meaning;
}

double [] getArr(int _a) {
    
    double [] _arr = new double [_a];
    
    for(int i = 0; i < _a; i++) {
        _arr[i] = new Random().NextDouble() * 1000;
        }

        return _arr;
} 

void printArr(double[] _arr) {
    for(int i = 0; i < _arr.Length; i++) {
        Console.Write($"{_arr[i]} ");
    }
} 

