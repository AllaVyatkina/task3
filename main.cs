using System;

class Program {
  public static void Main (string[] args) {
  Console.WriteLine("Введите число");
    int n = int.Parse(Console.ReadLine());
    int count = 1;

    while (count <= n)
    {

      Console.WriteLine(Math.Pow(count,3));
      count += 1;}
  }
}