﻿/*
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"First roll: {roll2}");
Console.WriteLine($"First roll: {roll3}");


dice.Next();

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(secondValue, firstValue);

Console.WriteLine(largerValue);

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

roll1 = 2;
roll2 = 1;
roll3 = 1;

int total = roll1 + roll2 + roll3; 

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{ 
    if ((roll1 == roll2) && (roll2 == roll3))
    {
    total += 6;
    Console.WriteLine($"You rolled triples! +6 bonus to total! New total: {total}");
    }
    else
    {
        total += 2;
        Console.WriteLine($"You rolled doubles! +2 bonus to total! New total: {total}");
    }
}


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
} 
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total >= 7)
{
    Console.WriteLine("You win a new trip!");
}
else
{
  Console.WriteLine("You win a kitten!");  
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
daysUntilExpiration = 5;
int discountPercentage = 0;

if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired."); 
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine($"Your subscription expires within a day!");
        discountPercentage = 20;
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!");
        discountPercentage = 10;
    }
    else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine($"Your subscription will expire soon. Renew now!");
    }

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

Console.WriteLine("a" == "a"); // true
Console.WriteLine("a" == "A"); // false
Console.WriteLine(1 == 2); // false

string myValue = "a";
Console.WriteLine(myValue == "a"); // true

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


Console.WriteLine("a" != "a"); // false
Console.WriteLine("a" != "A"); // true
Console.WriteLine(1 != 2); // true

string myValue = "a";
Console.WriteLine(myValue != "a"); // false

Console.WriteLine(1 > 2); // false
Console.WriteLine(1 < 2); // true
Console.WriteLine(1 >= 1); // true
Console.WriteLine(1 <= 1); // true

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // true 
Console.WriteLine(pangram.Contains("cow")); // false

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("lol"));

int saleAmount = 999;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Random coin = new Random();
int coinFlip = coin.Next(1, 3);
Console.WriteLine((coinFlip == 1) ? "heads" : "tails");

string permission = "Manager";
int level = 15;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
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
        Console.WriteLine("You do not have sufficient privileges, Mr Manager.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Inside of code block: {value}");


bool flag = true;
if (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");



int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

string fruit = "apple";



switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for {fruit}");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry");
        break;
}


int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");