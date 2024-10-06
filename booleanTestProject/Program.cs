Console.Clear();
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);
Console.WriteLine("a" == "a ");

string myValue = "a";
Console.WriteLine(myValue == "a");

Console.WriteLine("---------------------");

string value1 = "   a  ";
string value2 = "       A            ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine(1 != 2);

Console.WriteLine("\n---------------------\n");

string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("Fox"));
Console.WriteLine(pangram.Contains("cow"));