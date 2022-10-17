int a;

string number1;
Console.Write("Введите длинну массива");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

int [] arr = {};

arr = getArr(a);
 
 
printArr(arr);

howEvenNubersInArr(arr);

void howEvenNubersInArr (int [] _arr) {
   int count = 0;

   for(int i = 0; i < _arr.Length; i++) {
    if(_arr[i] % 2 == 0) {
        count ++;

    } 
   }

   Console.Write($"Количество четных чисел в массиве равно {count}");
}


int [] getArr(int _a) {
    
    int [] _arr = new int [_a];
    
    for(int i = 0; i < _a; i++) {
        _arr[i] = new Random().Next(100, 1000);
        }

        return _arr;
} 

void printArr(int[] _arr) {
    for(int i = 0; i < _arr.Length; i++) {
        Console.Write($"{_arr[i]} ");
    }
} 