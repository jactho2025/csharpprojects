Console.Clear();
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine();

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine();

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

//string myValue2 = "a";
Console.WriteLine(myValue != "a");
Console.WriteLine();

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
Console.WriteLine();

string dialog = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(dialog.Contains("fox"));
Console.WriteLine(dialog.Contains("fox") == false);
Console.WriteLine(dialog.Contains("cow"));
Console.WriteLine(!dialog.Contains("cow"));
Console.WriteLine();

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
Console.WriteLine();

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50; // (condition) ? (return value here if true) : (return value here if false)
Console.WriteLine($"Discount: {discount}");
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Console.WriteLine();

Console.WriteLine("CHALLENGE:");
Random random = new Random();
int coinFlip = random.Next(0, 2);
Console.WriteLine($"Flipping a coin... It is {(coinFlip == 0 ? "Heads" : "Tails")}.");
Console.WriteLine();

Console.WriteLine("CHALLENGE 2:");
int level = 55;
string permission = "Admin|Manager";

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

