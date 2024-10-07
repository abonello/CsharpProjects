Console.Clear();
Console.WriteLine("Process String Array Content\n");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach(var currentString in myStrings)
{
  string myString = currentString;
  
  do
  {
    periodLocation = myString.IndexOf(".");
    if (periodLocation != -1)
    {
      Console.WriteLine(myString.Substring(0, periodLocation).Trim());
      myString = myString.Substring(periodLocation + 1);
      continue;
    }
    Console.WriteLine(myString.Trim());
  } while (periodLocation != -1);
}