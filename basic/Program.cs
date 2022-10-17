int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

int [] arr = {};

arr = getArr(a);

printArr(arr);

int resolt = getMinMeaningFromArr(arr);

Console.Write($"Min {resolt}");


int getMaxMeaningFromArr(int[] _arr) {
   int meaning = _arr[0];

   for(int i = 1; i < _arr.Length; i++) {
    if(meaning < _arr[i]) {

        meaning = _arr[i];
        }

    }

   return meaning;
}






int getMinMeaningFromArr(int[] _arr) {
   int meaning = _arr[0];

   for(int i = 1; i < _arr.Length; i++) {
    if(meaning > _arr[i]) {

        meaning = _arr[i];
        }

    }

   return meaning;
}

int [] getArr(int _a) {
    
    int [] _arr = new int [_a];
    
    for(int i = 0; i < _a; i++) {
        _arr[i] = new Random().Next(1, 100);
        }

        return _arr;
} 

void printArr(int[] _arr) {
    for(int i = 0; i < _arr.Length; i++) {
        Console.Write($"{_arr[i]} ");
    }
} 

