using System;
class MainClass {
  /*Проверить, является ли билет счастливым по-московски (abcdef => a+b+c = d+e+f)*/
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine ("Является ли билет счастливым по-московски?" + CheckLucky(num));
  }
          
  public static bool CheckLucky(int num)
  {
    int f = num % 10;
    int e = num % 100 / 10;
    int d = num % 1000 / 100;
    int c = num % 10000 / 1000;
    int b = num % 100000 / 10000;
    int a = num / 100000;
    
    return (a + b + c == d + e + f);
  }
}