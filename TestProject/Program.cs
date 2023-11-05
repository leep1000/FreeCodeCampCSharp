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
*/

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3; 

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    total += 2;
    Console.WriteLine($"You rolled doubles! +2 bonus to total! New total: {total}");
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    total += 6;
    Console.WriteLine($"You rolled triples! +6 bonus to total! New total: {total}");
}

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total <= 14)
{
    Console.WriteLine("Sorry, you lose.");
}