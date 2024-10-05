Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.Clear();
Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}\n");

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine($"You rolled triples! +6 bonus to total!\n\tTotal is now: {total}\n");
    total += 6;
}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    total += 2;
    Console.WriteLine($"You rolled doubles! +2 bonus to total!\n\tTotal is now: {total}\n");
}

Console.WriteLine("\n\nYou need a total of 15 to win.\n");
Console.WriteLine("-------------");
Console.WriteLine($"Results:\nTotal: {total}\n\n");

if (total >= 15)
{
    Console.WriteLine("You win!\n");
}
else
{
    Console.WriteLine("Sorry, you lose.\n");
}