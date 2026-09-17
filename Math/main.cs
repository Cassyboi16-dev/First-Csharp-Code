
// basic addition

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// mix data types 

string firstName = "Samuel";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " +( widgetSold + 7 )+ " widgets.");

// basic mathematical operators

int sum = 7+5;
int difference = 7-5;
int product = 7*5;
int quiotient = 7/5;

Console.WriteLine("Sum: "+sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: "+product);
Console.WriteLine("Quotient: "+quiotient);


// performing division using decimal

decimal decimalQuotient = 7.0m / 5;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");




// casting results of integer divisions

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);


// modulus % operator that gives remainder after integer division

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");


// order of operations

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);




