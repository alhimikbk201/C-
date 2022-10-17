int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

int [] arr = {};

arr = getArr(a);

printArr(arr);

getSumNotevenPositionArr(arr);

int [] getArr(int _a) {
    
    int [] _arr = new int [_a];
    
    for(int i = 0; i < _a; i++) {
        _arr[i] = new Random().Next(1, 100);
        }

        return _arr;
} 

void getSumNotevenPositionArr(int []_arr) {

    int sum = 0;

    for(int i = 0; i < _arr.Length; i++) {
        if(i % 2 != 0) {
            sum += _arr[i];
        }

        
        
    }

    Console.Write($"Сумма значений нечетный позиций равна {sum}");

}

void printArr(int[] _arr) {
    for(int i = 0; i < _arr.Length; i++) {
        Console.Write($"{_arr[i]} ");
    }
} 