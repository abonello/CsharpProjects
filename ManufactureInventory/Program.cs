string[] names = [ "Rowena", "Robin", "Bao"];
int[] inventory = [ 200, 450, 700, 175, 250 ];
int sum = 0;
int bin = 0;

Console.Clear();
Console.WriteLine("╔════════════════════╗");
foreach (string name in names)
{
    Console.WriteLine($"║  {name.PadRight(18)}║");
}
Console.WriteLine("╚════════════════════╝");
Console.WriteLine("\n\n\n");

Console.WriteLine("┌──────────────────────────────────────────┐");
foreach (int items in inventory)
{
  sum += items;
  bin++;
  Console.WriteLine($"│  Bin {bin} = {items} items (Running total: {sum})".PadRight(43) + "│");
}

Console.WriteLine("│".PadRight(43) + "│");
Console.WriteLine($"│  We have {sum} items in inventory.".PadRight(43) + "│");
Console.WriteLine("└──────────────────────────────────────────┘");
Console.WriteLine("\n\n\n");