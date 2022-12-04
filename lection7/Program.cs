// собрать сроку из чисел от а до б циклом
/*string NumberFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumberFor(1, 5));
*/
// рекурсией
/*
string NumberRec(int a, int b)
{
    if(a<b) return $"{a} " + NumberRec(a+1,b);
    else return $"{b} ";
}
Console.WriteLine(NumberRec(1, 5));
*/
// от большего к меньшему т.е. от б до а
/*
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for(int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumberFor(1, 5));
*/
/*
string NumberRec(int a, int b)
{
    
        if(a<b) return  NumberRec(a+1,b) + $"{a} ";
        else return $"{b} ";


}
Console.WriteLine(NumberRec(1, 5));
*/
/*
// сумма элементов от 1 до н
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i<=n; i++) result +=i;
    return result;
}
Console.WriteLine(SumFor(5));
*/

/*
int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(5));
*/
// факториал числа
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i =1; i <= n; i++) result *=i;
    return result;
}
Console.WriteLine(FactorialFor(5));
*/
/*
int FactorialRec(int n)
{
    if(n== 1) return 1;
    else return FactorialRec(n-1)*n;
}
Console.WriteLine(FactorialRec(5));
*/
// вычислить а в степени н

/*
int PowerIn(int a, int n)
{
    int result = 1;
    for(int i = 1; i <=n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerIn(5,3));
*/
/*
int PowerIn(int a, int n)
{
    //if(n == 0) return 1;
    //else return a*PowerIn(a,n-1);
    // тернарный оператор
    return n == 0 ? 1 : PowerIn(a, n - 1) * a;
}
Console.WriteLine(PowerIn(5,3));
*/
//уменьшаем кол-во операций
/*
int PowerMath(int a, int n)
{
    if(n == 0) return 1;
    else if (n%2 ==0) return PowerMath(a*a,n/2);
    else return PowerMath(a, n-1) * a;
}
Console.WriteLine(PowerMath(2,10));
*/

// Перебор слов из имеющихся букв
/*
char[] s = {'а', 'и', 'с', 'в'};

    int count = s.Length;
    int n = 1;
    for(int i = 0; i < count; i++)
    { 
        for(int j = 0; j < count; j++)
        {
            for (int k = 0; k < count; k++)
            {
                for (int l = 0; l < count; l++)
                {
                    Console.WriteLine($"{n++, -5} {s[i]}{s[j]}{s[k]}{s[l]}");
                }
            }
        }
    }
    */
// как сделать это же когда не известна заранее сколько букв в словах должно быть (переборами как для кол=ва игроков)


// делаем это же рекурсией
/*
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 1; i < alphabet.Length; i ++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);
*/
/*
string path = "D:/GEEK/Программирование_C#";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for(int i = 0; i<fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
void CatalogInfo(string path, string indent ="")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

FileInfo[] files = catalog.GetFiles();
for(int i =0; i<files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
CatalogInfo(@"D:/GEEK/Программирование_C#");
*/
// пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{ 
    if(count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count -1);

}
Towers();
*/
// арифметическое выражение в рекурсии графом ((4-2) * (1+3))/10
/*
string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2*pos;
        int right = 2*pos + 1;
        if(left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);        
    }
}
InOrderTraversal();
*/
// фибоначчи
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0|| n==1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration{n}) = {FibonacciIteration(n)} fIte = {fIte}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now -dt).TotalMilliseconds);
Console.WriteLine();


Console.ReadLine();
dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion{n}) = {FibonacciRecursion(n)} fRec = {fRec}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now -dt).TotalMilliseconds);
Console.ReadLine();
