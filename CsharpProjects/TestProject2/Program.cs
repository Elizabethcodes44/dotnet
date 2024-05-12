// See https://aka.ms/new-console-template for more information
Random days = new Random();
int daysUntilExpiration = days.Next(12);
int discountPercentage = 0;
//Add a feature to a software. the feature wıll ımprove the renewal rate of subscrıptıons to the software.
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
//Arrays in Csharp
string [] fraudulentOrderIDs = new string[3] // the brackets after string indicates an array. the new creates a new ınstance of an arry. and the 3 indicates the number of elements the array can hold.