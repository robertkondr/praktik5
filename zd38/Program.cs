//Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76

using System;
class HelloWorld {
  static void Main()
  {
      
        double [] arr=GetArrayDouble(20,-1000,1000);
        PrintArrayDouble(arr);
        double result=distace(arr);
        Console.Write($"\n{result}");
    }
  static double distace(double[] arr)
  {
      
        double maxValue=arr[0];
        double minValue=arr[0];
      foreach(int num in arr)//ноль не четноё так как в реальности счёт с 1
      {
          if(maxValue<num)
          {
              maxValue=num;
          }
          if(minValue>num){
            minValue=num; 
          }
      }
      return maxValue-minValue;
  }
  
  static void PrintArrayDouble(double[] arr)
    {
        // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (double el in arr)
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
 static double[] GetArrayDouble(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        double coeff= new Random().NextDouble();
        result[i] =minValue+(maxValue-minValue)*coeff;

    }
    return result;
}
}