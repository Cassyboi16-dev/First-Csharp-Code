// increment and decrement


int value = 1;
value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// increment and decrement positions

int value2 = 1;
value2++;
Console.WriteLine("First: " + value2);
Console.WriteLine($"Second: {value2++}");
Console.WriteLine("Third: " + value2);
Console.WriteLine("Fourth: " + (++value2));

















