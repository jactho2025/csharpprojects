/*
Random random = new Random();
int current = random.Next(1, 11);


do {
    current = random.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);



while (current >= 3) {
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last Number: {current}");
*/

/*
Random random = new Random();
int playerHealth = 10;
int enemyHealth = 10;
bool playerTurn = true;
int damage = 0;
do {
    damage = random.Next(1, 10);

    if (playerTurn == true) {
        playerTurn = false;
        enemyHealth -= damage;
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {enemyHealth} health.");
    } else {
        playerTurn = true;
        playerHealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {playerHealth} health.");
    }
} while (playerHealth >= 1 && enemyHealth >= 1);
*/

/*
string? readResult = null;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter a number between 5 and 10: ");

do {
    readResult = Console.ReadLine();

    if (readResult != null) {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true) {
        if (numValue <= 5 || numValue >= 10) {
            validNumber = false;
            Console.WriteLine($"{numValue} is an invalid number. Please enter a number between 5 and 10.");
        }
    } else {
        Console.WriteLine("Please enter a number between 5 and 10.");
    }
} while (validNumber == false);
Console.WriteLine($"Number {numValue} has been accepted.");
*/

/*
string? readResult = null;
string roleName = "";
bool validEntry = false;

do {
    Console.WriteLine("Enter your role name (Administrator, Manager or User): ");
    readResult = Console.ReadLine();

    if (readResult != null) {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") {
        validEntry = true;
    } else {
        Console.WriteLine($"The role \"{roleName}\" is not valid.");
    }

} while (validEntry == false);

Console.WriteLine($"Welcome, {roleName}!");
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}