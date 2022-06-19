using System;
using static System.Console;
Clear();

WriteLine("Enter max string length");    
int maxStrLength = int.Parse(ReadLine());
WriteLine("Enter array size");
int arrSize = int.Parse(ReadLine()); 
int sortLength = 3;                                 //отбор по длине строки n.

string [] resultArr = new string [arrSize];
int count =0;                               //счетчик кол-ва строк <= n и размера итогового массива.
int j =0;

string[]randomArr = new string[arrSize];
    for (int i = 0; i < arrSize; i++)
    {   
        int strLength = new Random().Next(1,maxStrLength);
        string arrString = new string(GetString(strLength));
        randomArr[i]= arrString;
        if(strLength<=sortLength)
        {
            count++;
            resultArr[j]=randomArr[i];
            j++;
        }        
    }

WriteLine($"START ARRAY:");
PrintArray(randomArr,arrSize);
WriteLine();
WriteLine();

if(count == 0)
{
WriteLine($"В массиве нет строк, соответвующих условию");
}
else
{
WriteLine($"RESULT ARRAY:");
PrintArray(resultArr, count);
}



void PrintArray(string[]randArr, int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        Write($"  >{randArr[i]}<  ");
    }
    WriteLine();
}


char []GetString(int stringLength)
{
    char[]getString = new char [stringLength];
    for(int i = 0; i<stringLength; i++)
    {
        int randSymb = new Random().Next(1,127);
        char symb = (char)randSymb;
        getString[i] = symb;
    }
return getString;
}

