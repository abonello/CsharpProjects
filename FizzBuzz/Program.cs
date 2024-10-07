Console.Clear();
Console.WriteLine("\u001b[4mFizz Buzz\u001b[0m\n");

/*
  Rules:
  Count up to 100
  /3 Fizz
  /5 Buzz
  /15 Fiuzz
  Other numbers print the number
*/

/* Imperative implementation */


for (int i = 1; i < 101; i++)
{
  var div3 = i % 3 == 0;
  var div5 = i % 5 == 0;
    if (div3 && div5)
      Console.WriteLine($"{i} - FizzBuzz");
    else if (div3)
      Console.WriteLine($"{i} - Fizz");
    else if (div5)
      Console.WriteLine($"{i} - Buzz");
    else
      Console.WriteLine(i);
}