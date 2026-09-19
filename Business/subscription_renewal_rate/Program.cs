Random random = new Random();

int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;


 if (dayUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (dayUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage += 20}%!");
}
else if (dayUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.\nRenew now and save {discountPercentage += 10}%");
}   
if(dayUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon, Renew now!");
}