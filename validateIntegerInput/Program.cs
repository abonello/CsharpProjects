Console.Clear();
Console.WriteLine("Validate Integer Input");

string? readResult;
int numValue;
bool numberIsValid = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
  readResult = Console.ReadLine();
  numberIsValid = int.TryParse(readResult, out numValue);

  if(!numberIsValid)
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
    continue;
  }
  if (numValue < 5 || numValue > 10)
  {
    Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
    numberIsValid = false;
    continue;
  }
  Console.WriteLine($"Your input value ({numValue}) has been accepted.");
  numberIsValid = true;

} while (!numberIsValid);