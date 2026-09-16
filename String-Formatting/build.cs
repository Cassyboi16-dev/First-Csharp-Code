// string concatenation

string firstName = "Samuel";
string message = "Hello " + firstName;
Console.WriteLine(message);

// multiple string concatenation

string secondName = "Thelma";
string greeting = "Hello";
string notification = greeting + " " + secondName + "!"; // intermediate variable
Console.WriteLine(notification); 

// avoiding intermediate variables

string thirdName = "Nestor";
string saluatations = "Hiya";
Console.WriteLine(saluatations + " " + thirdName + "!");

// string interpolation


string fourthName = "Noel";
string notify = $"Whatsup {fourthName}!";
Console.WriteLine(notify);

int version = 11;
string updateText = "Update to linux";
string text = $"{updateText} {version}"; // intermediate variable
Console.WriteLine(text);

int distroVersion = 12;
string update = "Update to Mac";
Console.WriteLine($"{update} {distroVersion}! and leave windows alone it's sloppy");

// verbatim + interpolation literal

string project = "First-Project";
Console.WriteLine($@"C:\User\hp\{project}\AppData");
