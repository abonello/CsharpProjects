Random random = new Random();
int daysUntilExpiration = random.Next(12);
// int daysUntilExpiration = 11;
int discountPercentage = 0;


Console.Clear();
Console.WriteLine("Welcome to the Renewal App\n---------------------------\n");

if (daysUntilExpiration == 0) {
  Console.WriteLine("Your subscription has expired!\n\n\n");
}
else if (daysUntilExpiration == 1) {
  discountPercentage = 20;
  Console.WriteLine($"Your subscription expires within a day!");
}
else if (daysUntilExpiration <=5) {
  discountPercentage = 10;
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10) {
  Console.WriteLine("Your subscription will expire soon.\nRenew now!\n\n\n");
}


if (discountPercentage > 0) {
  Console.WriteLine($"Renew now and save {discountPercentage}%!\n\n\n");
}



// Console.WriteLine(daysUntilExpiration);