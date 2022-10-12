int a;

string number1;
Console.Write("Введите число");

number1 = Console.ReadLine()!;

int.TryParse(number1, out a);

int i = 0;
int j = 4;
int c, v;

a += 100000;
while(i <= 2 ) {
  
    c = a / (int)Math.Pow(10, j) % 10;
    v = a / (int)Math.Pow(10, i) % 10;
    if(c != v ) {
        Console.Write("Не полиндром  ");
       
       
        break;

    } else {
        
        i++;
        j--;

        if(i == 2) {
            Console.Write("Полиндром");
}
    }

   

}

