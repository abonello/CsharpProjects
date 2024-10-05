Console.Clear();
Console.WriteLine("Validate String Input\n");

string[] roles = { "administrator", "manager", "user" };
string? input;
bool roleIsValid = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
  input = Console.ReadLine();

  if (!roles.Contains(input.Trim().ToLower()))
  {
    Console.WriteLine($"The role name that you entered, \"{input.Trim()}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    continue;
  }

  roleIsValid = true;

} while(!roleIsValid);

Console.WriteLine($"Your input value ({input.Trim()}) has been accepted.");