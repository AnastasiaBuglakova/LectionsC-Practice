// Находим максимум стихийно
/*int a1 = 3;
int b1 = 8;
int c1 = 6;
int a2 = 4;
int b2 = 33;
int c2 = 6;
int a3 = 14;
int b3 = 13;
int c3 = 16;*/
/*int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
Console.WriteLine(max);*/

// Находим максимум через метод
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}
/*int Max1 = Max(a1, b1, c1);
int Max2 = Max(a2, b2, c2);
int Max3 = Max(a3, b3, c3);
int max = Max(Max1, Max2, Max3);*/
/*int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);*/

// Массив IntroArray
/*
int[] array = { 2, 7, 9, 6, 3, 5, 6, 0, 1};
array[0] = 7;
int mmax =  Max(Max(array[0], array[1], array[2]), 
            Max(array[3], array[4], array[5]), 
            Max(array[6], array[7], array[8]));


Console.WriteLine(mmax);
*/

// Имеется одномерный массив из n элементов, требуется найти элемент массива, равный find/
/*int[] array = { 2, 7, 9, 6, 3, 5, 6, 0, 1};
int find = 6;
int le = array.Length;
int ind = 0;
while(ind < le)
{
    if(array[ind] == find)
    {
        Console.WriteLine(ind);
        break;
    }
    ind++;
}*/

void FillArray(int[] collection)
{
    int le = collection.Length;
    int index = 0;
    while(index < le)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    
    }
}
void PrintArray(int[] col)
{

    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int[] xyz = new int [32];
FillArray(xyz);
PrintArray(xyz);
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
} 
Console.Write("->");
xyz[4] = 8;
xyz[5] = 8;
int pos = IndexOf(xyz, 33);

Console.WriteLine(pos + " ");