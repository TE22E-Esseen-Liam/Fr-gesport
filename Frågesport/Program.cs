using System;


string choice = "";

Console.WriteLine("How much has this young fella spent on Valorant?");
Console.WriteLine("2000kr [a] 10 000kr[b] 6 500kr[c]");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{

Console.WriteLine("Wrong");
Console.WriteLine("Much more than that");
Console.WriteLine("");    //empty rad
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
Console.WriteLine("That's right");
Console.WriteLine("Good job");
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
Console.WriteLine("lucky guess");
Console.WriteLine("");
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
}


else if (boys == "b")
{
Console.WriteLine("hole in one");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Good job");
}

else if (boys == "c")
{
Console.WriteLine("Wrong");
Console.WriteLine("");
Console.WriteLine("Nice try tho");
Console.WriteLine("");
}

Console.ReadLine();