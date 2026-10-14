
// string[] colors = new string[9];

// colors[0] = "Hello Samuel";
// colors[1] = "It's Such a pleasure";
// colors[2] = "To meet you";
// colors[3] = "Tell me do you";
// colors[4] = "BLEED!";
// colors[5] = "Also are you capable";
// colors[6] = "Of loving someone";
// colors[7] = "Even when they reject you";
// colors[8] = "Or those it scare you?!";

// Random stuff = new Random();
// int array = stuff.Next(20, 45);
// if(array == 40)
// {
//     Console.WriteLine($"{colors[5].ToUpper().Length} is num {array}");
// }else if(array == 45)
// {
//     Console.WriteLine($"{colors[2].ToUpper().Length} is num {array}");
// }
// else
// {
//     Console.WriteLine($"Number is {array}");
//     Console.ReadLine();
// }


// Console.WriteLine(colors);
// foreach(string hue in colors)
// {
//    string pigment = hue.ToCharArray();
//    Console.WriteLine(pigment);
// }




// Store And manage LIST 

List<string> colors = new List<string> { "red", "green", "blue" };

Console.WriteLine(colors.Count); // Output: 3
colors.Add("yellow");            // Adds "yellow" to the end
Console.WriteLine(colors.Count); // Output: 4

colors.Remove("red");            // Removes "red"
colors[0] = "purple";            // Replaces "green" with "purple"

List<string> names = new List<string> {"Sam", "Carly", "Spencer", "Freedie", "Gilbert"};
names.Remove("Gilbert");
names[3] = "Freedie's Mom";
Console.WriteLine(names.Count);

foreach(string words in names)
{
    Console.WriteLine(words);
}