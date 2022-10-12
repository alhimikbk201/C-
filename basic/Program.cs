void distanceDot (int [] _A, int [] _B) {
    double _s;

    _s = Math.Sqrt(Math.Pow((_A[0] - _B[0]), 2) + Math.Pow((_A[1] - _B[1]), 2) + Math.Pow((_A[2] - _B[2]), 2));
    Console.Write(_s);
}

int [] A = {};
int [] B = {};


int [] inputDot() {
int [] _A = {0, 0 , 0}; 
Console.Write("Введите X");
int.TryParse(Console.ReadLine()!, out _A[0]);

Console.Write("Введите Y");
int.TryParse(Console.ReadLine()!, out _A[1]); 

Console.Write("Введите Z");
int.TryParse(Console.ReadLine()!, out _A[2]); 

return _A;
}

A = inputDot();
B = inputDot();

distanceDot(A, B);

