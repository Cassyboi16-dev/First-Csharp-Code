string[] illegalOrders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string fake in illegalOrders)
{
    if (fake.StartsWith("B"))
    {
        Console.WriteLine(fake);
    }
}





