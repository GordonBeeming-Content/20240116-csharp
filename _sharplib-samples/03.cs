using System;
// https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AXEBLANgHwAEAmARgFgAoQgZgAISHSB2KgbyrofsJToFkAhtgB2ACgCUnOh0pcuAZwDu2DGAAWdMQBFBGGABVsAWxgA6AKpqAchCVndATwDyAMwDqMGAGspc+bLy8mCCCjB0Tm6ePmb8ECIAJoKOINJBXISkAJxiAERxIrkSANxp6cCwgt6l/kEhYRHJUV7eZgYArjAKSSllQZk5uR0wRTXp8hUwVWPp9eGRHi1mngkiXT2ptekDeSujfROV1QdzjS6LMQbq7VDdyZvjGdl5V+37W0GT0yeh800XrQAYlBsBsDk9BsDsO9HnQvscPnRTgtoq0AMp6G5gxEQvIYjAwx7wmZ1X5nZoxNHtRL3cFMQZUwolOnEg4JGCuQTtXBYOk7XLU7wiOwiOg9QnjVlbAC+0lllHlQA===
public class Program
{
  public void Main()
  {
    switch (DateTime.UtcNow.DayOfWeek)
    {
      case DayOfWeek.Monday:
        Console.WriteLine("Mon");
        break;
      case DayOfWeek.Tuesday:
        Console.WriteLine("Tue");
        break;
      case DayOfWeek.Wednesday:
        Console.WriteLine("Wed");
        break;
      case DayOfWeek.Thursday:
        Console.WriteLine("Thu");
        break;
      case DayOfWeek.Friday:
        Console.WriteLine("Fri");
        break;
      case DayOfWeek.Saturday:
        Console.WriteLine("Sat");
        break;
      case DayOfWeek.Sunday:
        Console.WriteLine("Sun");
        break;
      default:
        Console.WriteLine("unknown day");
        break;
    }
  }
}
