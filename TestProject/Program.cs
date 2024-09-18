Boolean debug = false;

Console.WriteLine("Welcome to Triple Dip!\n");
Console.WriteLine("Rolling three die... done.\n");
Random dice = new Random();
int roll1, roll2, roll3;
if (debug == false) {
    roll1 = dice.Next(1,7);
    roll2 = dice.Next(1,7);
    roll3 = dice.Next(1,7);
}
else
{ //Test variables
    roll1 = 6;
    roll2 = 6;
    roll3 = 6;
}

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}\n");

//Check for doubles or triples.
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!\n");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!\n");
        total += 2;
    }
}

Console.WriteLine("Final score: " + total + "\n");

//Victory messages:
if (total >= 16) {
    Console.WriteLine("You win a new car!");
}
else if (total >= 10) {
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7) {
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Console.WriteLine();