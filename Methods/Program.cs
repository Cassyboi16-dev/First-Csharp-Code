// Defining a method

// void Greet()
// {
//     Console.WriteLine("Hello Samuel this code is a method");
// }

// Greet();

// Adding parameters

using System.Text;

void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

Greet("Jane");
Greet("Samuel");


// Adding multiple parameters

void Eat(string food, string chef)
{
    Console.WriteLine($"{food}, {chef}!");
}


Eat("Rice", "Hilda");



// optional parameters with default values

void Sleep(string greeting, string time = "Morning")
{
    Console.WriteLine($"{greeting}, {time}");
}

Sleep("Good");
Sleep("Good", "Afternoon");
Sleep("Good", "Evening");
Sleep(greeting: "Good", time: "Night");// passing arguments by name.

// Returning values from methods

// Declaring a return type

int Add(int apple, int ball)
{
    return apple + ball;

}



decimal Divide(decimal cup, decimal dog)
{
    return cup / dog;
}


int result = Add(23, 45);

decimal result2 = Divide(2.34m, 3.4m);


Console.WriteLine($"The sum of 23 + 45 = {result}");

Console.WriteLine($"The sum of (23 + 45) * 10 is {(23 + 45) * 10} not {result}");

Console.WriteLine(Add(10, 5) % 2);


Console.WriteLine(result2);


// Returning multiple values with tuples

(string x, string y) GetName()
{
    return ("Samuel", "James");
}


var (x, y) = GetName();
Console.WriteLine($"x: {x}, y: {y}");


// Local Variables

int CalculateTotal(int price, int tax)
{
// each call to a method gets it's own variable to avoid overwrite
    // int total = CalculateTotal(10, 2);// local variable
    return price + tax;
}

int resolve = CalculateTotal(23, 45);
Console.WriteLine($"The {resolve} variable is local to the method: CalculateTotal()");



// Organize code with namespaces



StringBuilder builder = new StringBuilder();
builder.Append("Hello, ");
builder.Append("world!");
Console.WriteLine(builder.ToString()); // Output: Hello, world!

namespace MathUtilities
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
