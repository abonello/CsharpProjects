int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);


// bool flag = true;
// int value;

// if (flag)
// {
//   value = 10;
//   Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

int val1 = 5;

if (val1 > 0) {
  int val2 = 6;
  val1 = val1 + val2;
}

Console.WriteLine(val1);

string name = "steve";

if (name == "bob")
  Console.WriteLine("Found Bob");
else if (name == "steve")
  Console.WriteLine("Found Steve");
else
  Console.WriteLine("Found Chuck");