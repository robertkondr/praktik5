//Домашнее задание
//Задание Пример
//Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

using System;
class HelloWorld {
  static void Main()
  {
      
        int [] arr=GetArray(20,100,999);
        PrintArray(arr);
        int result=counteven(arr);
        Console.Write($"\n{result}");
    }
  static int counteven(int[] arr)
  {
      int count=0;
      foreach(int num in arr)
      {
          if(num%2!=1)
          {
              ++count;
          }
      }
      return count;
  }
  
  static void PrintArray(int[] arr)
    {
        // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
            return number;
    }   
    static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);

    }
    return result;
}
}

