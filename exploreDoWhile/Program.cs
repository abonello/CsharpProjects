
Console.Clear();
Console.WriteLine("Explore Do While Loop");

Random random = new();
int current = 0;
int counter = 1;

do
{
  current = random.Next(1, 11);
  Console.WriteLine($"{counter}:\t{current}");
  counter++;
} while (current != 7);

Console.WriteLine("\nUsing Continue\n");

current = random.Next(1, 11);

do
{
  current = random.Next(1, 11);

  if (current >= 8) continue;

  Console.WriteLine(current);
} while (current != 7);