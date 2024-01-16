using System;
public class Program
{
  public void Main()
  {
    var animal = Console.ReadLine();
    switch (animal)
    {
      case "dog":
        Console.WriteLine("woof");
        break;
      case "cat":
        Console.WriteLine("meow");
        break;
      case "fish":
        Console.WriteLine("blub");
        break;
      default:
        Console.WriteLine("unknown animal");
        break;
    }
  }
}
