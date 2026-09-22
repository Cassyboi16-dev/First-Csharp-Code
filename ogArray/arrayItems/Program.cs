// declaring of arrays

// string[] fraudulentOrderIDs = new string[3];

// assigning values to elements of an array

/*fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";*/
// fraudulentOrderIDs[3] = "D000";


// declaring and initializing arrays

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];


// retrieving values from elements in an array

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// reassign value to array

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// output with the length property

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

















