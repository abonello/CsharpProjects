// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("The FOR Loop");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-------------------\n");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-------------------\n");


for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-------------------\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{names.Length  - i}: {names[i]}");
}


/*
foreach (var name in names)
{
    // Cannot assign to 'name' because it is a 'foreach iteration variable'
    // Can't do this:
    if (name == "David") name = "Sammy";
}
*/

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); 
