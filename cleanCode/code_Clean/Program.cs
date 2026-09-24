/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalText = "The quick brown fox jumps over the lazy dog.";

char[] message = originalText.ToCharArray();
Array.Reverse(message);

int alphabetCount = 0;
foreach (char letter in message)
{
    if (letter == 'o')
    {
        alphabetCount++;

    }
}

string newmessage = new String(message);

Console.WriteLine(newmessage);
Console.WriteLine($"'o' appears {message} times.");
