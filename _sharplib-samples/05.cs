using System;
// https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA+ABATARgLABQGAzAATbk4DshA3oaeWRiqQLICGAlgHYAUASgal6BRowBuHKKQAmHAJ6kAvKQAiHAC4wAKlwC2MAHQBVTWAByEAO5GNCgPIAzAOowYAayM6IAZU1QvADmggDaAAwAugDcwowAztZc5gAWpHzyCkJi4qLi4mAc8TCkAORspSBx+ZQAnHwARGwQPA0CsTk1pMCwHB4dXYXFZTqV1fkYOPUNOgCuJdCkOimzbQNd3b3946RDJaUuY501k9Nusms7jD0wfev5sjBOHLMANppVxxNTjQBU/5cvuIbndqgBfYQQghQoA==
public class Program
{
  public void Main()
  {
    var day = DateTime.UtcNow.DayOfWeek.ToString()[0];
    switch (day)
    {
      case 'M':
        Console.WriteLine("Mon");
        break;
      case 'T':
        Console.WriteLine("Tue or Thu");
        break;
      case 'W':
        Console.WriteLine("Wed");
        break;
      default:
        Console.WriteLine("***");
        break;
    }
  }
}
