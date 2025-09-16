Console.WriteLine("What is your name?\n");

string userName = (Console.ReadLine());

Console.WriteLine("\nA lovely name, I shall remember it.\nNow " + userName + " I must ask, how much gold do you currently possess?\n");

int userGold = int.Parse(Console.ReadLine());

Console.WriteLine("\nI see... a Bronze Sword Costs 15 Gold.\n");


if (userGold >= 15)
{
    int userGold1 = (userGold - 15);
    Console.WriteLine("Well " + userName + ", you can afford this sword.\nYou're remaining gold is a sum of: " + userGold1);
}
else
{
    Console.WriteLine("I'm sorry " + userName + " but you don't have enough gold.");
}

Console.WriteLine("\n\nEnd\n\n");

