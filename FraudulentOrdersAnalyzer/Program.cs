Console.Clear();

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/


/*
// C# 1 - Array initialization
// string[] fraudulentOrderIDs = new string[] { "A123", "B456", "C789" };

// C# 3 - Implicitly typed arrays - old syntax
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// C# 12 - Collection expression syntax
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];


Console.WriteLine($"First fraudulent order ID: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second fraudulent order ID: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third fraudulent order ID: {fraudulentOrderIDs[2]}");
// Console.WriteLine($"Fourth fraudulent order ID: {fraudulentOrderIDs[3]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

string[] fraudulentOrderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

foreach(string orderID in fraudulentOrderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}