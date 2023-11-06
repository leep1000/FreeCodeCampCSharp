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
*/

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