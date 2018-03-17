using System;
class MainClass {
  /*По двум членам арифметической прогрессии и шагу прогрессии посчитать количество элементов и сумму элементов прогрессии между данными членами.
  Члены прогрессии и шаг – вещественные числa.*/
  public static void Main (string[] args) {
    int first = int.Parse(Console.ReadLine());
    int last = int.Parse(Console.ReadLine());
    int step = int.Parse(Console.ReadLine());
    
    Console.WriteLine ("It has " + CountElements(first, last, step) + " elements");
    Console.WriteLine("The sum of elements is " + CountSum(first, last, step));
  }
          
  public static int CountElements(int first, int last, int step)
  {
    return (last - first) / step + 1;
  }
  
  public static int CountSum(int first, int last, int step) {
    return (first + last) / 2 * CountElements(first, last, step);
  }
}