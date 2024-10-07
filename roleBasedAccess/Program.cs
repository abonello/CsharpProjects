string[] permissionsAvailable = new string[] { "Admin", "Manager", "User" };
Random random = new Random();
string permission = permissionsAvailable[random.Next(permissionsAvailable.Length)];
// int level = 55;
int level = random.Next(100);
Console.Clear();
Console.WriteLine("Access Control\n");

if (permission == "Admin")
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.\n\n");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.\n\n");
    }
}
else if (permission == "Manager")
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.\n\n");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.\n\n");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.\n\n");
}


//Debug
Console.WriteLine($"Permission: {permission}, Level: {level}\n");


// Admin > 55 Welcome, Super Admin user.
// Admin <= 55 Welcome, Admin user.
// Manager >= 20 Contact an Admin for access.
// Manager < 20 You do not have sufficient privileges.

// Not Admin|Manager - Irrispective of level
// You do not have sufficient privileges.