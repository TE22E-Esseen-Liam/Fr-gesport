using System;
using System.Xml.Schema;

int points = 0;

string choice = "";

Console.WriteLine("How much has do you think this guy has spent on Valorant?");
Console.WriteLine("200$ [a] 1000$[b] 650$[c]");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{

Console.WriteLine("Wrong");
Console.WriteLine("Much more than that");
Console.WriteLine("");
Console.WriteLine("How old is Valorant");
Console.WriteLine("1 year [a] 2 years [b] 3 years[c]");
}


else if (choice == "b")
{
Console.WriteLine("Wrong");
Console.WriteLine("Not that much");
Console.WriteLine("");
Console.WriteLine("How old is Valorant");
Console.WriteLine("1 year [a] 2 years [b] 3 years[c]");
}

else if (choice == "c")
{
points++;
Console.WriteLine("That's right");
Console.WriteLine("Good job");
Console.WriteLine($"You have {points} point/s");
Console.WriteLine("");
Console.WriteLine("How old is Valorant");
Console.WriteLine("1 year [a] 2 years [b] 3 years[c]");
}

string tab = "";

Console.WriteLine("");

tab = Console.ReadLine();
tab = tab.ToLower();

if (tab == "a")
{
Console.WriteLine("wrong");
Console.WriteLine("");
Console.WriteLine("What is a OP in valorant");
Console.WriteLine("rifle [a] sniper [b] shotgun [c]");
}


else if (tab == "b")
{
Console.WriteLine("Wrong");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("What is a OP in valorant");
Console.WriteLine("rifle [a] sniper [b] shotgun [c]");
}

else if (tab == "c")
{
points++;
Console.WriteLine("lucky guess");
Console.WriteLine($"You have {points} point/s");
Console.WriteLine("");
Console.WriteLine("What is a OP in valorant");
Console.WriteLine("rifle [a] sniper [b] shotgun [c]");
}



string boys = "";

Console.WriteLine("");
Console.WriteLine("");

boys = Console.ReadLine();
boys = boys.ToLower();

if (boys == "a")
{

Console.WriteLine("Wrong");
Console.WriteLine("");
Console.WriteLine("Good try tho");
Console.WriteLine("");
Console.WriteLine($"you got {points} out of 3");
}


else if (boys == "b")
{
points++;
Console.WriteLine("hole in one");
Console.WriteLine($"You have {points} point/s");
Console.WriteLine("");
Console.WriteLine("Good job");
Console.WriteLine($"you got {points} out of 3");
}

else if (boys == "c")
{
Console.WriteLine("Wrong");
Console.WriteLine("");
Console.WriteLine("Nice try tho");
Console.WriteLine("");
Console.WriteLine($"you got {points} out of 3");
}


Console.ReadLine();