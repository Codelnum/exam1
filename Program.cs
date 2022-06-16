using System;
using static System.Console;
Clear();

WriteLine("Enter array size"); 
int size = int.Parse(ReadLine());      
string[] StrArr = GetArray(size);
WriteLine("Result array:");
PrintArray(StrArr);




void PrintArray(string[]StrArr)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{StrArr[i]} ");
    }
    
}


string[]GetArray(int size)
{
    string[]fillArray = new string [size];
    for(int i = 0; i<size; i++)
    {
        WriteLine($"Введите строку {i+1}");
        string enteredString = ReadLine();
        if (enteredString.Length <= 3)
        {
        fillArray[i] = enteredString;
        }
    }
return fillArray;
}
