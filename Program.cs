// See https://aka.ms/new-console-template for more information

// Build a program that will show a vendors items
//Ask the user to enter a number from the menu
//Using the information, use a switch (either type) to show the item's cost
//Ask the user for their name, if it matches yours divide the cost in half


Console.WriteLine("Welcome Travler, What is your name?");
string name = Console.ReadLine();



Console.Write("The following items are available for purchase:\n");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Rope");
Console.WriteLine("4 - Clean Water ");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");


Console.Write("Please choose a number: ");
int option = Convert.ToInt32(Console.ReadLine());

string itemName = option switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Rope",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Try another Selection"
};

float itemCost = option switch

{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0

};

if (name == "jeff")
{
    itemCost /= 2;
    Console.WriteLine("Welcome Jeff! Please Enjoy your 50% off discount!");
    Console.WriteLine($"The cost of {itemName} is {itemCost}");
} else
Console.WriteLine($"The cost of {itemName} is {itemCost}");


