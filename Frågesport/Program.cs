using System;

string choice = "";

Console.WriteLine("Hur mycket pengar har Liam Spenderat på Valorant?");
Console.WriteLine("2000kr [a] 10 000kr[b] 6 500kr[c]");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{

Console.WriteLine("Fel");
Console.WriteLine("inte så lite");
}


else if (choice == "b")
{
Console.WriteLine("Fel");
Console.WriteLine("inte så mycket");
}

else if (choice == "c")
{
Console.WriteLine("Rätt ");
Console.WriteLine("Jag kunde köpt en bil");
}


Console.ReadLine();