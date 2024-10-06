Console.Clear();
Console.WriteLine("Welcome to the Coin Flip Game!");

Random random = new();
int flip = random.Next(2);
string result = flip == 0 ? "Heads" : "Tails";

Console.WriteLine($"The coin landed on: {result}!\n\n");

// Debugging
Console.WriteLine(flip);