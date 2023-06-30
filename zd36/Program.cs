//Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
class HelloWorld {
  static void Main()
  {
      
        int [] arr=GetArray(2,100,999);
        PrintArray(arr);
        int result=sumoddindex(arr);
        Console.Write($"\n{result}");
    }
  static int sumoddindex(int[] arr)
  {
      int sum=0;
      for(int i=0;i<arr.Length;++i)//ноль не четноё так как в реальности счёт с 1
      {
          if(i%2!=1)
          {
              sum+=arr[i];
          }
      }
      return sum;
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