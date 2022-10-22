// Вид 1 - не возвращают и не принимают
/*void Method1()
{
    Console.WriteLine("Автор: Анастасия Буглакова");
}
Method1();*/

// Вид 2  - не возвращают, но принимают
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Тext of message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
       Console.WriteLine(msg);
       i++; 
    }
}
Method21("bla, bla", 3);
// а можно указать и явно:
Method21(msg: "bla, bla, bla", count: 4);
// и не обязательно по порядку 
Method21(count: 1, msg: "bla");*/

// Вид 3  - возвращают, но не принимают
// Зацикливание програмы остановить => ctrl + c
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/

// Вид 4 - принимают и возвращают
/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "kakapaka");
Console.WriteLine(res);*/
