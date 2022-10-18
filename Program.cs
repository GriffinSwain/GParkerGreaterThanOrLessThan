//Griffin Parker
//October 18, 2022
//Mini Challenge 4 Remastered - Greater Than or Less Than
//Using if statements to compare two different numbers, my program will tell the user if their numbers are greater, lesser, or equal to each other
//Code Peer-reviewed by

bool loop = true;
string repeat = "";

while (loop == true)
{
Console.Clear();
Console.WriteLine("Please enter a number!");
string number1 = Console.ReadLine();
Console.WriteLine("Now please enter a second number! I will then let you know which one is greater, which one is lesser, or if they are equal to each other.");
string number2 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
Console.WriteLine("");

//Checking first number versus the second
if (num1 > num2){
Console.WriteLine(num1 + " is greater than "+ num2);
}
if (num1 < num2){
    Console.WriteLine(num1 + " is lesser than " + num2);
}
if (num1 == num2){
    Console.WriteLine(num1 + " is equal to " + num2);
}

//Checking second number versus the first
if (num2 < num1){
Console.WriteLine(num2 + " is lesser than "+ num1);
}
if (num2 > num1){
    Console.WriteLine(num2 + " is greater than " + num1);
}
Console.WriteLine();
while (loop == true)
{
Console.WriteLine("Would you like to compare numbers again? \"yes\" or \"no\"?");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "yes")
{
loop = false;
}
if (repeat == "no")
{
loop = false;
}

}
if (repeat == "yes")
{
loop = true;
}
}
