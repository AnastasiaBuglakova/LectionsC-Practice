// Example001
//Console.WriteLine("2 Hello, World!");

// Example002
/*Console.WriteLine("Please, enter your name:");
string userName = Console.ReadLine();
Console.WriteLine("Hello," + userName);*/

// Example003
/*int numberA = 3;
int numberB = 9;
Console.WriteLine(numberA + numberB);*/

// Example004
/*double numberA = 10;
double numberB = 6;
Console.WriteLine(numberA / numberB);*/

// Example004-1
/*double numberA = new Random().Next(1, 10);
double numberB = 6;
Console.WriteLine(numberA);
Console.WriteLine(numberA / numberB);*/

// Example005
/*Console.WriteLine("Please, enter your name:");
string userName = Console.ReadLine();
if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
Console.WriteLine("Привет, " + userName);*/

// Example006
/*int a = 1;
int b = 9;
int c = 0;
int d = 3;
int e = 7;
int f = 2;
int max = a;
if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;
if(max < f) max = f;
Console.Write("max = " + max);*/

// Example007
Console.Clear();
//Console.SetCursorPosition(10, 0);
//Console.WriteLine("+");
int xa = 40, ya = 1, 
    xb = 1, yb = 30, 
    xc = 80, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa, y = ya;
int count = 0;
while(count < 5000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
