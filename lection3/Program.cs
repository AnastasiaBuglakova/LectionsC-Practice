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

// цикл FOR
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "kakapaka");
Console.WriteLine(res);*/

// Цикл внутри цикла

/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();// искусственнный разрыв
}*/

// Обработка теста
//Дан текст. Нужно во всем тексте заменить пробелы черточками, 
//маленькие буквы К заменить большими, большие С заменить маленькими.

/*string t = "adsflj;j";
              01234567
s[3]      =    "f" */
/*
string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов,"
            + " а также будем использовать их на практике. "
            + "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

// Цикл внутри цикла и сортировка массива

int[] Array = {100,6,2,7,9,1,2,4};
void PrintArray(int[] Array)
{
    int count = Array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] Array)
{
    for(int sortedSize = 0; sortedSize  < (Array.Length - 1); sortedSize ++)
    {
    int posMin = sortedSize;
        for (int j = sortedSize + 1; j < Array.Length; j++)
            {
            if(Array[posMin] > Array[j]) posMin = j;
            }
    int help = Array[sortedSize];
    Array[sortedSize] = Array[posMin];
    Array[posMin] = help;
    }
}
SortArray(Array);
PrintArray(Array);

/// Сортируем от большего к меньшему

/* int[] Array = {8,6,2,7,9,3,2,4};
void PrintArray(int[] Array)
{
    int count = Array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] Array)
{
    for(int sortedSize = 0; sortedSize  < (Array.Length - 1); sortedSize ++)
    {
    int posMin = sortedSize;
        for (int j = sortedSize + 1; j < Array.Length; j++)
        {
        if(Array[posMin] < Array[j]) posMin = j;
        }
    int help = Array[sortedSize];
    Array[sortedSize] = Array[posMin];
    Array[posMin] = help;
    }
}
SortArray(Array);
PrintArray(Array);*/