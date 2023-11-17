/*
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

Console.WriteLine($"Product: {size} {color} {type}");
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

string[] fraudulentOrderIDs = {"A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
string[] OrderIDsWithB = {};

foreach (string ID in orderIDs)
{
    if(ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}

string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i=0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// The high-level purpose of this code is to reverse a string and count the number of times a particular character appears.
// Then prints the results

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] reverseMessage = originalMessage.ToCharArray();
Array.Reverse(reverseMessage);

int count = 0;

foreach (char letter in reverseMessage) 
{ 
    if (letter == 'o') 
    { 
        count++; 
    } 
}

string newMessage = new String(reverseMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");

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

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
    {
        break;
    }
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

// FizzBuzz Challenge

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8)
    {
        continue;
    }

    Console.WriteLine(current);
} while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

Random dice = new Random();

int heroHP = 10;
int enemyHP = 10;

bool isHeroTurn = true;

while (heroHP > 0 && enemyHP > 0)
{
    int attack = dice.Next(1, 7);

    if (isHeroTurn)
    {
        enemyHP -= attack;
        Console.WriteLine($"Enemy was damaged and lost {attack} health and now has {enemyHP} health.");
        // isHeroTurn = false;
    }
    else
    {
        heroHP -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health.");
        // isHeroTurn = true;
    }

    // Console.WriteLine($"{(isHeroTurn ? "Enemy" : "Hero")} was damaged and lost {attack} health and now has {(isHeroTurn ? enemyHP : heroHP)}.");
    isHeroTurn = !isHeroTurn;
}

string winner = heroHP > 0 ? "Hero" : "Enemy";
Console.WriteLine($"{winner} wins!");

*/


