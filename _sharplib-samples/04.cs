using System;
// https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA+ABATARgLABQGAzAATbk4DshA3oaeWRiqQLICGAlgHYAUASgal6BRowBuHKKQAmHAJ6kAvKQAiHAC4wAKlwC2MAHQBVTWAByEAO5GNCgPIAzAOowYAayM6IAZU1QvADmggDcwowAztZc5gAWpHzyCkJi4qLi4mAckTCkAERsEDzJ+SARmZQAnHyFxfkC4WmVpMCwHB5NLdm5BToArjCRpeXNlRg4NfkDMA1dLa3tnRWMPXn5brI8QyMr4hNTm3N7jG0wHfOZsjBOHP0ANpqjC9W1AFQfx2OZZxcVAL7CQEEYFAA
public class Program
{
  public void Main()
  {
    var day = DateTime.UtcNow.DayOfWeek.ToString();
    switch (day)
    {
      case "Monday":
        Console.WriteLine("Mon");
        break;
      case "Tuesday":
        Console.WriteLine("Tue");
        break;
      case "Wednesday":
        Console.WriteLine("Wed");
        break;
      default:
        Console.WriteLine("***");
        break;
    }
  }
}
