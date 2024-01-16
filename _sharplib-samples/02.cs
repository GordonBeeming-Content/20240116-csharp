using System;
// https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AXEBLANgHwAEAmARgFgAoQgZgAISHSB2KgbyrofsJToFkAhtgB2ACgCUnOh0pcuAN0FQ6AE0EBPOgF46Y0RgkARQRhgAVbAFsYAOgCqGMADkIAd1smNAeQBmAdRgYAGsAbmkuAGc3bCcACz11DSk5eVl5eTBBSJg6UhAIjKYATjEAIn4IETKJcNSiumBYQTDCriycumIC+qLCUlKy8wBXGBq6hq4mmBaJydUYX0Fh3Cw2+X7BgCod8fWp5tbegF9pU8pzoA===
public class Program
{
  public void Main()
  {
    var day = (int)DateTime.UtcNow.DayOfWeek;
    switch (day)
    {
      case 1:
        Console.WriteLine("Mon");
        break;
      case 2:
        Console.WriteLine("Tue");
        break;
      default:
        Console.WriteLine("***");
        break;
    }
  }
}
