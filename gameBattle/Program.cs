Console.Clear();
Console.WriteLine("Game Battle\n");

/*
Rules:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();

while (heroHealth > 0 && monsterHealth > 0)
{
  int heroAttack = random.Next(1, 11);
  monsterHealth -= heroAttack;
  Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
  if (monsterHealth <= 0)
  {
    Console.WriteLine("Hero wins!");
    break;
  }

  int monsterAttack = random.Next(1, 11);
  heroHealth -= monsterAttack;
  Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
  if (heroHealth <= 0)
  {
    Console.WriteLine("Monster wins!");
    break;
  }
}