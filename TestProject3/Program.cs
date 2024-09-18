
string firstName = "Bob";
int widgetsPurchased = 7;
//Testing a change to the message.
//int widgetsSold = 7;
//Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

Console.WriteLine("\n");

/*
The following code creates five random OrderIDs
to test the fraud detection process. OrderIDs
consist of a letter from A to E, and a three
digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

Console.WriteLine("\n");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

Console.WriteLine("\n");

/*
The high-level purpose of this code block is to
reverse a string message and count the number
of times a particular letter appears in said message.
*/
string message = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage) {
    if (letter == 'o') { 
        letterCount++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");