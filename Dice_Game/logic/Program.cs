
// initializing a new random method

Random dice = new Random();


// adding it to the Next() method for adding the range of random values

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);




// roll1 = 5;
// roll2 = 1;
// roll3 = 1;



// sum of the rest from the Next() method

int total = roll1 + roll2 + roll3;

// total = 7;


// Output of the values and total sum

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if statements for the logic && bonus points

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}


if(total >= 1)
{
    Console.WriteLine("You win a new car!");
}else if (total >= 10)
{
    Console.WriteLine("You win a laptop!");
}else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}

else
{
    Console.WriteLine("Sorry, you lose you get nothing.");
   
}