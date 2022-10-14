void getArray() {
    int [] _intArr = {0,0,0,0,0,0,0,0};
    for(int i = 0; i < 8; i++) {
        _intArr[i] = new Random().Next(0, 100);
    }

    foreach(var item in _intArr) {
        Console.Write($"{item} ");

    }

}

getArray();