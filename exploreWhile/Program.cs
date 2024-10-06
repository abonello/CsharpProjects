Console.Clear();
Console.WriteLine("Explore WHILE Loop");

Random random = new();
int current = random.Next(1,11);

while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1,11);
}

System.Console.WriteLine($"Last number: {current}");
