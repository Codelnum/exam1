using System;
using static System.Console;

WriteLine("Enter max string length");    
int maxStrLength = int.Parse(ReadLine());
WriteLine("Enter array size");
int startArraySize = int.Parse(ReadLine()); 
int sortLength = 3;                                 //отбор по длине строки n.

string[]startArray = new string[startArraySize];
int count = 0;                                      //счетчик кол-ва строк с длиной <= n и размер итогового массива.
    for (int i = 0; i < startArraySize; i++)
    {   
        int strLength = new Random().Next(1,maxStrLength);
        string arrString = new string(GetString(strLength));
        startArray[i]= arrString;
        if(strLength<=sortLength)
        {
            count++;
        }        
    }

string [] resultArray = new string [count];
int j = 0;                                  
for (int i = 0; i <startArraySize; i++)
{
    if (startArray[i].Length<=sortLength)
    {
        resultArray[j]= startArray[i];
        j++;
    }
}


WriteLine($"START ARRAY:");
PrintArray(startArray,startArraySize); WriteLine();WriteLine();


if(count == 0)
{
WriteLine($"В массиве нет строк, соответвующих условию");
}
else
{
WriteLine($"RESULT ARRAY(size = {count}):");
PrintArray(resultArray, count);
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

